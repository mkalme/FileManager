using System;
using FastStream;

namespace FileManager {
    public class Entry {
        private string _headerName;
        public string HeaderName {
            get => _headerName;
            set {
                var tmp = _headerName;
                _headerName = value;
                if (tmp != value) OnChange();
            }
        }

        private string _name;
        public string Name {
            get => _name;
            set {
                var tmp = _name;
                _name = value;
                if (tmp != value) OnChange();
            }
        }

        private string _password;
        public string Password {
            get => _password;
            set {
                var tmp = _password;
                _password = value;
                if (tmp != value) OnChange();
            }
        }

        public Entry(string headerName) {
            _headerName = headerName;
            _name = "";
            _password = "";
        }
        public Entry() {
            _headerName = "";
            _name = "";
            _password = "";
        }

        //Event
        public event EventHandler PropertyChanged;
        private void OnChange() {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, EventArgs.Empty);
        }

        internal static Entry Deserialize(FastBinaryReader reader) {
            Entry entry = new Entry();

            entry._headerName = reader.ReadString();
            entry._name = reader.ReadString();
            entry._password = reader.ReadString();

            return entry;
        }
        internal void Serialize(FastBinaryWriter writer) {
            writer.Write(_headerName);
            writer.Write(_name);
            writer.Write(_password);
        }

        //Update Entry
        internal void Update(Entry entry) {
            _headerName = entry._headerName;
            _name = entry._name;
            _password = entry._password;
        }

        //Default Methods
        public bool Equals(Entry entry) {
            if (entry == null) return false;

            if (_headerName != entry._headerName) return false;
            if (_name != entry._name) return false;

            return _password == entry._password;
        }
        public Entry Clone() {
            Entry entry = new Entry();

            entry._headerName = _headerName;
            entry._name = _name;
            entry._password = _password;

            return entry;
        }
    }
}
