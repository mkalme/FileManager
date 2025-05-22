using System;
using System.Windows.Forms;
using FileManager;

namespace GUI {
    public partial class DocumentDialog : Form {
        public Document Document { get; set; }
        public bool CanBeSaved { get; set; } = false;

        public DocumentDialog(Document document)
        {
            InitializeComponent();
            InitializeUserComponent();

            Document = document;
            
            FontDialog.Font = Document.Font;
            ColorDialog.Color = Document.ForeColor;

            DisplayDocument();
        }
        private void InitializeUserComponent() {
            ToolTip.SetToolTip(ColorButton, "Change color");
        }

        private void DisplayDocument() {
            TextRichTextBox.Text = Document.Notes;
            TextRichTextBox.Font = Document.Font;
            TextRichTextBox.ForeColor = Document.ForeColor;
        }

        private Document GetDocument() {
            Document document = new Document(Document.Name);

            document.Notes = TextRichTextBox.Text;
            document.Font = TextRichTextBox.Font;
            document.ForeColor = TextRichTextBox.ForeColor;

            return document;
        }

        //Buttons
        private void ChangeFontButton_Click(object sender, EventArgs e){
            FontDialog.ShowDialog();

            TextRichTextBox.Font = FontDialog.Font;
        }
        private void ColorButton_Click(object sender, EventArgs e){
            ColorDialog.ShowDialog();

            TextRichTextBox.ForeColor = ColorDialog.Color;
        }

        private void ActivateDone() {
            Document.Update(GetDocument());
            CanBeSaved = true;
        }

        private void DoneButton_Click(object sender, EventArgs e){
            ActivateDone();

            Close();
        }

        private void DocumentDialog_FormClosing(object sender, FormClosingEventArgs e){
            if (CanBeSaved) return;
            if (Document.Equals(GetDocument())) return;

            ConfirmationDialog dialog = DialogFactory.ShowSaveDialog();

            if (dialog.Confirmation == ConfirmationType.Yes) {
                ActivateDone();
            } else if (dialog.Confirmation == ConfirmationType.Cancel) {
                e.Cancel = true;
            }
        }
    }
}
