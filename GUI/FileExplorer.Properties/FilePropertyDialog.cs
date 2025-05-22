using System;
using System.Globalization;
using System.Windows.Forms;
using FileManager;

namespace GUI {
    public partial class FilePropertyDialog : Form {
        private PasswordFile File { get; set; }

        public FilePropertyDialog(PasswordFile file){
            InitializeComponent();

            File = file;

            Display();
        }

        private void Display() {
            NameTextBoxPanel.Text = File.Name;

            LocationTextBox.Text = File.GetPath();
            LengthTextBox.Text = $"{File.Password.Length} characters";
            PasswordEditedTextBox.Text = $"{File.PasswordChange.Parse()}  ({(DateTime.Now - File.PasswordChange).ParseTimeSpan()})";

            CreatedTextBox.Text = File.CreationDate.Parse();
            ModificationTextBox.Text = File.ModificationDate.Parse();
        }

        private void ChangePasswordDateButton_Click(object sender, EventArgs e){
            DateTime time = File.PasswordChange;
            if (!DialogFactory.ShowDateInputDialog("Password edit date", "Change edit password date", ref time)) return;

            File.ChangePasswordChangeDate(time);
            ManagerInfo.Save();

            Display();
        }
        private void PasswordEditHistory_Click(object sender, EventArgs e) {
            DialogFactory.ShowPasswordEditHistoryDialog(File);
        }

        private void CloseButton_Click(object sender, EventArgs e){
            Close();
        }
    }
}
