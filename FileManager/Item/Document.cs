using System;
using System.Drawing;
using FastStream;
using FastStream.Extensions;

namespace FileManager {
    public class Document : Item {
        public string _notes = string.Empty;
        public string Notes {
            get => _notes;
            set {
                var tmp = _notes;
                _notes = value;
                if (tmp != value) OnChange();
            }
        }
        public Font Font { get; set; }

        private Color _foreColor;
        public Color ForeColor {
            get => _foreColor;
            set {
                var tmp = _foreColor;
                _foreColor = value;
                if (tmp != value) OnChange();
            }
        }

        internal Document() { 
        }
        public Document(string name) {
            _name = name;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;

            Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            ForeColor = SystemColors.HighlightText;
        }

        //Deserialize
        internal static Document Deserialize(FastBinaryReader reader) {
            Document document = new Document();

            document.ReadItem(reader);

            document._notes = reader.ReadString();
            document.Font = reader.ReadFont();
            document._foreColor = reader.ReadColor();

            return document;
        }

        //Serialize
        internal override void Serialize(FastBinaryWriter writer){
            base.Serialize(writer);

            writer.Write(_notes);
            writer.Write(Font);
            writer.Write(_foreColor);
        }
        internal override void SerializeID(FastBinaryWriter writer){
            writer.Write(GetType().GetID());
        }

        //Update File
        public void Update(Document document){
            _name = document._name;

            _notes = document._notes;
            Font = document.Font;
            _foreColor = document._foreColor;

            OnChange();
        }

        //Default Methods
        public override FileDirectory GetRootDirectory(){
            return _parent.GetRootDirectory();
        }

        public override bool Equals(Item item){
            if (!base.Equals(item)) return false;
            if (item.GetType() != GetType()) return false;
            Document document = (Document)item;

            if (_notes != document._notes) return false;
            if (!Font.FontEquals(document.Font)) return false;
            if (_foreColor != document._foreColor) return false;

            return true;
        }
        public override Item Clone(){
            Document document = new Document();

            document._name = _name;
            document.CreationDate = CreationDate;
            document.ModificationDate = ModificationDate;

            document._notes = _notes;
            document.Font = (Font)Font.Clone();
            document._foreColor = _foreColor;

            return document;
        }
    }
}
