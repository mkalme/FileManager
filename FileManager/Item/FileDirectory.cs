using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using FastStream;
using AesEncryption;

namespace FileManager {
    public class FileDirectory : Item, IEnumerable {
        private List<Item> _items { get; set; }
        public IList<Item> Items => _items.AsReadOnly();

        public int Count => _items.Count;

        internal FileDirectory() {
            _items = new List<Item>();
        }
        public FileDirectory(string name) {
            _name = name;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;

            _items = new List<Item>();
        }

        //Methods
        public void Add(Item item) {
            item.PropertyChange += _contentsChange;
            item._parent = this;

            _items.Add(item);

            OnContentsChange();
        }
        public void Remove(int index) {
            Item item = _items[index];
            _items.RemoveAt(index);
            item.Delete();

            OnContentsChange();
        }
        public void Remove(Item item) {
            Type type = item.GetType();

            for (int i = 0; i < _items.Count; i++) {
                if (_items[i].GetType() != type) continue;
                if (_items[i].Name == item.Name) {

                    _items.RemoveAt(i);
                    item.Delete();
                    OnContentsChange();

                    return;
                }
            }
        }
        public void RemoveRange(int index, int count) {
            for (int i = index; i < index + count; i++) {
                Item item = _items[index];
                _items.RemoveAt(index);
                item.Delete();
            }

            OnContentsChange();
        }
        public void Clear() {
            bool toUpdate = _items.Count > 0;

            _items.Clear();

            if (toUpdate) OnContentsChange();
        }

        public string GetNewItemName(Type type, string fileName) {
            List<string> names = new List<string>();

            foreach (var item in _items) {
                if (item.GetType() == type) names.Add(item.Name);
            }

            string name = fileName;

            int count = 0;
            bool contains = true;
            do {
                if (names.Contains(name)) {
                    count++;
                    name = $"{fileName} ({count})";

                    continue;
                }

                contains = false;
            } while (contains);

            return name;
        }
        public bool IsSubDirectoryOf(FileDirectory parentDirectory) {
            FileDirectory directory = this;
            while (directory != null) {
                if (Object.ReferenceEquals(directory, parentDirectory)) return true;

                directory = directory._parent;
            }

            return false;
        }
        public FileDirectory GetDirectoryFromSubDirectory(FileDirectory subDirectory) {
            if (subDirectory == null) return null;

            FileDirectory directory = subDirectory;
            
            while (directory._parent != null) {
                if (Object.ReferenceEquals(this, directory._parent)) return directory;

                directory = directory._parent;
            }

            return null;
        }

        //Event
        private event EventHandler _contentsChange;
        public event EventHandler ContentsChange {
            add {
                _contentsChange += value;
                foreach (var item in _items) {
                    item.PropertyChange += value;
                }
            }
            remove {
                _contentsChange -= value;
                foreach (var item in _items) {
                    item.PropertyChange -= value;
                }
            }
        }

        private void OnContentsChange() {
            if (_contentsChange != null)
                _contentsChange.Invoke(this, EventArgs.Empty);
        }

        //Deserialize
        public static FileDirectory FromFile(string filePath, Key key) {
            FastBinaryReader reader = new FastBinaryReader(AES.Decrypt(File.ReadAllBytes(filePath), key));

            return Deserialize(reader);
        }
        public static FileDirectory FromBytes(byte[] bytes, Key key) {
            FastBinaryReader reader = new FastBinaryReader(AES.Decrypt(bytes, key));

            return Deserialize(reader);
        }

        internal static FileDirectory Deserialize(FastBinaryReader reader) {
            FileDirectory directory = new FileDirectory();

            directory.ReadItem(reader);

            int count = reader.ReadInt32();
            while (count > 0) {
                Item item = ManagerHelper.GetType(reader.ReadByte()).GetItem(reader);
                item._parent = directory;

                directory._items.Add(item);

                count--;
            }

            return directory;
        }

        //Serialize
        public byte[] ToBytes(Key key) {
            using (MemoryStream stream = new MemoryStream())
            using (FastBinaryWriter writer = new FastBinaryWriter(stream)) {
                Serialize(writer);

                return AES.Encrypt(stream.ToArray(), key);
            }
        }
        public void Save(string filePath, Key key) {
            using (MemoryStream stream = new MemoryStream())
            using (FastBinaryWriter writer = new FastBinaryWriter(stream)) {
                Serialize(writer);

                File.WriteAllBytes(filePath, AES.Encrypt(stream.ToArray(), key));
            }
        }

        internal override void Serialize(FastBinaryWriter writer) {
            base.Serialize(writer);

            writer.Write(_items.Count);
            foreach (var item in _items) {
                item.SerializeID(writer);
                item.Serialize(writer);
            }
        }
        internal override void SerializeID(FastBinaryWriter writer) {
            writer.Write(GetType().GetID());
        }

        //Default Methods
        public override FileDirectory GetRootDirectory() {
            if (_parent == null) return this;

            return _parent.GetRootDirectory();
        }
        public void GetAmountOfItemTypes(ref int directory, ref int file, ref int document) {
            foreach (var item in _items) {
                if (item.GetType() == typeof(PasswordFile)) file++;
                else if (item.GetType() == typeof(Document)) document++;
                else {
                    directory++;
                    ((FileDirectory)item).GetAmountOfItemTypes(ref directory, ref file, ref document);
                }
            }
        }
        internal override void Delete(){
            base.Delete();

            _items.ForEach(x => x.Delete());
        }

        public IEnumerator GetEnumerator() => _items.GetEnumerator();
        public override bool Equals(Item item){
            if (!base.Equals(item)) return false;
            if (item.GetType() != GetType()) return false;
            FileDirectory dir = (FileDirectory)item;

            if (dir._items.Count != dir._items.Count) return false;

            for (int i = 0; i < _items.Count; i++) {
                if (!_items[i].Equals(dir._items[i])) return false;
            }

            return true;
        }
        public override Item Clone(){
            FileDirectory directory = new FileDirectory();

            directory._name = _name;
            directory.CreationDate = CreationDate;
            directory.ModificationDate = ModificationDate;

            foreach (var item in _items) {
                Item i = item.Clone();

                i._parent = directory;
                directory._items.Add(i);
            }

            return directory;
        }
    }
}
