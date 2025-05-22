using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class NotesInputDialog : Form {
        public string InputText {
            get => NotesRichTextBoxPanel.InputText;
            set {
                NotesRichTextBoxPanel.InputText = value;
            }
        }
        public bool ReadOnly {
            get => NotesRichTextBoxPanel.ReadOnly;
            set => NotesRichTextBoxPanel.ReadOnly = value;
        }

        public delegate bool InputValidator(string input);
        public InputValidator Validator { get; set; }

        private bool _notesValidated = false;
        public bool NotesValidated { get => _notesValidated; }

        public NotesInputDialog(string input, InputValidator validator = null){
            InitializeComponent();

            InputText = input;
            Validator = validator;

            FontSizeUpDown.Value = (int)NotesRichTextBoxPanel.TextFont.Size;
        }

        private void DoneButton_Click(object sender, EventArgs e){
            if (Validator == null) {
                Close();
            } else {
                if (Validator.Invoke(NotesRichTextBoxPanel.InputText)) {
                    _notesValidated = true;
                    Close();
                }
            }
        }

        private void FontSizeUpDown_ValueChanged(object sender, EventArgs e){
            float size = (float)FontSizeUpDown.Value;
            if (size < 1) return;

            Font font = NotesRichTextBoxPanel.TextFont;

            NotesRichTextBoxPanel.TextFont = new Font(font.FontFamily, size, font.Style);
        }
    }
}
