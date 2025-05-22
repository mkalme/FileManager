using System;
using FastStream;
using FastStream.Extensions;

namespace FileManager {
    public class PasswordFile : Item {
        private string _website = string.Empty;
        public string Website {
            get => _website;
            set {
                var tmp = _website;
                _website = value;
                if (tmp != value) OnChange();
            }
        }

        private string _password = string.Empty;
        public string Password {
            get => _password;
            set {
                var tmp = _password;
                _password = value;
                if (tmp != value) {
                    PasswordChange = DateTime.Now;
                    PasswordChangeHistory.Add(PasswordChange);
                    OnChange();
                }
            }
        }

        private string _email = string.Empty;
        public string Email {
            get => _email;
            set {
                var tmp = _email;
                _email = value;
                if (tmp != value) OnChange();
            }
        }

        private string _notes = string.Empty;
        public string Notes {
            get => _notes;
            set {
                var tmp = _notes;
                _notes = value;
                if (tmp != value) OnChange();
            }
        }

        private Entry _entry1;
        public Entry Entry1 {
            get => _entry1;
            set {
                Entry tmp = _entry1;
                _entry1 = value;
                _entry1.PropertyChanged += new EventHandler(Entry_Changed);
                if (!tmp.Equals(value)) OnChange();
            }
        }

        private Entry _entry2;
        public Entry Entry2 {
            get => _entry2;
            set {
                Entry tmp = _entry2;
                _entry2 = value;
                _entry2.PropertyChanged += new EventHandler(Entry_Changed);
                if (!tmp.Equals(value)) OnChange();
            }
        }

        private bool _editable = true;
        public bool Editable {
            get => _editable;
            set {
                var tmp = _editable;
                _editable = value;
                if (tmp != value) OnChange();
            }
        }

        public DateTime PasswordChange { get; private set; } = DateTime.Now;
        public DateHistory PasswordChangeHistory { get; private set; } = new DateHistory();

        internal PasswordFile() {

        }
        public PasswordFile(string name) {
            _name = name;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;

            _entry1 = new Entry("Name");
            _entry2 = new Entry("Name");
        }

        //Event
        private void Entry_Changed(object sender, EventArgs e) {
            OnChange();
        }

        //Deserialize
        internal static PasswordFile Deserialize(FastBinaryReader reader) {
            PasswordFile file = new PasswordFile();

            file.ReadItem(reader);

            file.PasswordChange = reader.ReadDateTime();
            file.PasswordChangeHistory = DateHistory.Deserialize(reader);

            file._website = reader.ReadString();
            file._password = reader.ReadString();
            file._email = reader.ReadString();
            file._notes = reader.ReadString();

            file._entry1 = Entry.Deserialize(reader);
            file._entry2 = Entry.Deserialize(reader);

            file._editable = reader.ReadBool();

            return file;
        }

        //Serialize
        internal override void Serialize(FastBinaryWriter writer){
            base.Serialize(writer);

            writer.Write(PasswordChange);
            PasswordChangeHistory.Serialize(writer);

            writer.Write(_website);
            writer.Write(_password);
            writer.Write(_email);
            writer.Write(_notes);

            _entry1.Serialize(writer);
            _entry2.Serialize(writer);
            
            writer.Write(_editable);
        }
        internal override void SerializeID(FastBinaryWriter writer){
            writer.Write(GetType().GetID());
        }

        //Update File
        public void Update(PasswordFile file) {
            _name = file.Name;
            _website = file._website;

            if (_password != file._password) {
                PasswordChange = DateTime.Now;
                PasswordChangeHistory.Add(PasswordChange);
            }

            _password = file._password;
            _email = file._email;
            _notes = file._notes;

            _entry1.Update(file._entry1);
            _entry2.Update(file._entry2);

            _editable = file._editable;

            OnChange();
        }
        public void ChangePasswordChangeDate(DateTime time) {
            PasswordChange = time;
        }

        //Default Methods
        public override FileDirectory GetRootDirectory(){
            return _parent.GetRootDirectory();
        }

        public override bool Equals(Item item){
            if (!base.Equals(item)) return false;
            if (item.GetType() != GetType()) return false;
            PasswordFile file = (PasswordFile)item;

            if (_website != file._website) return false;
            if (_password != file._password) return false;
            if (_email != file._email) return false;
            if (_notes != file._notes) return false;
            if (!_entry1.Equals(file._entry1)) return false;
            if (!_entry2.Equals(file._entry2)) return false;
            if (_editable != file._editable) return false;

            return true;
        }
        public override Item Clone(){
            PasswordFile file = new PasswordFile();

            file._name = _name;
            file.CreationDate = CreationDate;
            file.ModificationDate = ModificationDate;

            file._website = _website;
            file._password = _password;
            file._email = _email;
            file._notes = _notes;

            file._entry1 = _entry1.Clone();
            file._entry2 = _entry2.Clone();

            file._editable = _editable;

            return file;
        }
    }
}
