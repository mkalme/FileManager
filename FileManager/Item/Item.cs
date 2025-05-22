using System;
using FastStream;

namespace FileManager
{
    public abstract class Item {
        internal FileDirectory _parent;
        public FileDirectory Parent => _parent;

        protected string _name;
        public string Name {
            get => _name;
            set {
                var tmp = _name;
                _name = value;
                if (tmp != value) OnChange();
            } 
        }

        public Status Status { get; private set; } = Status.Normal;

        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

        //Event
        public event EventHandler PropertyChange;
        protected void OnChange() {
            ModificationDate = DateTime.Now;

            if (PropertyChange != null)
                PropertyChange.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Deleted;
        protected void OnDeleted() {
            if (Deleted != null)
                Deleted.Invoke(this, EventArgs.Empty);
        }

        internal virtual void Delete() {
            Status = Status.Deleted;
            _parent = null;
            OnDeleted();
        }

        //Deserialize
        internal void ReadItem(FastBinaryReader reader) {
            _name = reader.ReadString();
            CreationDate = new DateTime(reader.ReadInt64());
            ModificationDate = new DateTime(reader.ReadInt64());
        }

        //Serialize
        internal virtual void Serialize(FastBinaryWriter writer) {
            writer.Write(_name);
            writer.Write(CreationDate.Ticks);
            writer.Write(ModificationDate.Ticks);
        }
        internal abstract void SerializeID(FastBinaryWriter writer);

        //Default Methods
        public virtual string GetPath() {
            if (_parent == null) return Name;

            return $"{_parent.GetPath()}\\{Name}";
        }
        public abstract FileDirectory GetRootDirectory();

        public virtual bool Equals(Item item) {
            if (item == null) return false;

            return _name == item.Name;
        }
        public abstract Item Clone();
    }

    public enum Status {
        Normal,
        Deleted
    }
}
