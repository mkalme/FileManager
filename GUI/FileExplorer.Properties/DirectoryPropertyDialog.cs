using System;
using System.Globalization;
using System.Windows.Forms;
using FileManager;

namespace GUI {
    public partial class DirectoryPropertyDialog : Form {
        private FileDirectory Directory { get; set; }

        public DirectoryPropertyDialog(FileDirectory directory){
            InitializeComponent();

            Directory = directory;

            Display();
        }

        private void Display() {
            NameTextBoxPanel.Text = Directory.Name;
            LocationTextBox.Text = Directory.GetPath();

            int directories = 0;
            int files = 0;
            int documents = 0;
            Directory.GetAmountOfItemTypes(ref directories, ref files, ref documents);

            ContainsTextBox.Text = $"{directories} directories, {files} files, {documents} documents";

            CreatedTextBox.Text = Directory.CreationDate.ToString("MMM dd, yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            ModificationTextBox.Text = Directory.ModificationDate.ToString("MMM dd, yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }

        private void CloseButton_Click(object sender, EventArgs e){
            Close();
        }
    }
}
