using System;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using FileManager;

namespace GUI {
    public partial class DocumentPropertyDialog : Form {
        private Document Document { get; set; }
        
        public DocumentPropertyDialog(Document document){
            InitializeComponent();

            Document = document;

            Display();
        }

        private void Display() {
            NameTextBoxPanel.Text = Document.Name;
            LocationTextBox.Text = Document.GetPath();

            Font font = Document.Font;

            FontTextBox.Text = font.FontFamily.Name;
            FontTextBox.Font = new Font(font.FontFamily.Name, StyleTextBox.Font.Size, StyleTextBox.Font.Style);

            SizeTextBox.Text = $"{font.Size} px";

            StyleTextBox.Text = font.Style.ToString();
            StyleTextBox.Font = new Font(StyleTextBox.Font.FontFamily.Name, StyleTextBox.Font.Size, font.Style);

            Color color = Document.ForeColor;
            ColorPanel.BackColor = color;
            ColorTextBox.Text = $"RGB [{color.R}, {color.G}, {color.B}]";

            CreatedTextBox.Text = Document.CreationDate.ToString("MMM dd, yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            ModificationTextBox.Text = Document.ModificationDate.ToString("MMM dd, yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }

        private void CloseButton_Click(object sender, EventArgs e){
            Close();
        }
    }
}
