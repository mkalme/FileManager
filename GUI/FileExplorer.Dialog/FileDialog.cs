using System;
using System.Windows.Forms;
using FileManager;

namespace GUI {
    public partial class FileDialog : Form {
        public PasswordFile File { get; set; }

        public delegate bool ValidateName(string name, PasswordFile file);
        public ValidateName Validator { get; set; }
        public bool CanBeSaved { get; set; } = false;

        public FileDialog(PasswordFile file, ValidateName validator)
        {
            InitializeComponent();
            InitializeUserComponent();

            File = file;
            Validator = validator;

            DisplayDialog(File);
        }
        private void InitializeUserComponent() {
            NameGroupBox.Paint += PanelExtensions.PaintBorderlessGroupBox;
            WebsiteGroupBox.Paint += PanelExtensions.PaintBorderlessGroupBox;
            PasswordGroupBox.Paint += PanelExtensions.PaintBorderlessGroupBox;
            EmailGroupBox.Paint += PanelExtensions.PaintBorderlessGroupBox;
            NotesGroupBox.Paint += PanelExtensions.PaintBorderlessGroupBox;
            Entry1GroupBox.Paint += PanelExtensions.PaintBorderlessGroupBox;
            Entry2GroupBox.Paint += PanelExtensions.PaintBorderlessGroupBox;
            GenerateGroupBox.Paint += PanelExtensions.PaintBorderlessGroupBox;

            ToolTip.SetToolTip(ZoomNotesButton, "Zoom notes");
        }

        private void FileDialog_Shown(object sender, EventArgs e){
            SaveButton.Focus();
        }

        private void DisplayDialog(PasswordFile file){
            NameTextBoxPanel.Text = file.Name;
            WebsiteTextBoxPanel.Text = file.Website;
            PasswordTextBoxPanel.Text = file.Password;
            EmailTextBoxPanel.Text = file.Email;
            NotesRichTextBoxPanel.InputText = file.Notes;

            //Entry1
            Entry1NameLabel.Text = file.Entry1.HeaderName;
            Entry1NameTextBoxPanel.Text = file.Entry1.Name;
            Entry1PasswordTextBoxPanel.Text = file.Entry1.Password;

            //Entry2
            Entry2NameLabel.Text = file.Entry2.HeaderName;
            Entry2NameTextBoxPanel.Text = file.Entry2.Name;
            Entry2PasswordTextBoxPanel.Text = file.Entry2.Password;

            if (EditableCheckBox.Checked == file.Editable) {
                SetEditability(file.Editable);
                return;
            }

            EditableCheckBox.Checked = file.Editable;
        }
        private void SetEditability(bool editable){
            NameTextBoxPanel.ReadOnly = !editable;
            WebsiteTextBoxPanel.ReadOnly = !editable;
            PasswordTextBoxPanel.ReadOnly = !editable;
            EmailTextBoxPanel.ReadOnly = !editable;
            NotesRichTextBoxPanel.ReadOnly = !editable;

            //Entry1
            Entry1NameTextBoxPanel.ReadOnly = !editable;
            Entry1PasswordTextBoxPanel.ReadOnly = !editable;
            Entry1NameLink.ClickEnabled = editable;

            //Entry2
            Entry2NameTextBoxPanel.ReadOnly = !editable;
            Entry2PasswordTextBoxPanel.ReadOnly = !editable;
            Entry2NameLink.ClickEnabled = editable;
        }

        private PasswordFile GetFile() {
            PasswordFile file = new PasswordFile(NameTextBoxPanel.Text);

            file.Website = WebsiteTextBoxPanel.Text;
            file.Password = PasswordTextBoxPanel.Text;
            file.Email = EmailTextBoxPanel.Text;
            file.Notes = NotesRichTextBoxPanel.InputText;

            //Entry1
            file.Entry1.HeaderName = Entry1NameLabel.Text;
            file.Entry1.Name = Entry1NameTextBoxPanel.Text;
            file.Entry1.Password = Entry1PasswordTextBoxPanel.Text;

            //Entry2
            file.Entry2.HeaderName = Entry2NameLabel.Text;
            file.Entry2.Name = Entry2NameTextBoxPanel.Text;
            file.Entry2.Password = Entry2PasswordTextBoxPanel.Text;

            file.Editable = EditableCheckBox.Checked;

            return file;
        }

        //Password & Email
        private void CopyPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            PasswordTextBoxPanel.Text.SetToClipBoard();
        }
        private void PasswordTextBoxPanel_TextChange(object sender, EventArgs e){
            CharactersLengthLabel.Text = $"{PasswordTextBoxPanel.Text.Length} characters";
        }

        private void CopyEmailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            EmailTextBoxPanel.Text.SetToClipBoard();
        }

        //Notes
        private void CopyNotesLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            NotesRichTextBoxPanel.InputText.SetToClipBoard();
        }
        private void ZoomNotesButton_Click(object sender, EventArgs e){
            NotesInputDialog dialog = DialogFactory.GetNotesDialog(NotesRichTextBoxPanel.InputText);
            dialog.ReadOnly = !EditableCheckBox.Checked;
            dialog.ShowDialog();

            if (EditableCheckBox.Checked) {
                NotesRichTextBoxPanel.InputText = dialog.InputText;
            }
        }

        //Entry1
        private void Entry1CopyPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Entry1PasswordTextBoxPanel.Text.SetToClipBoard();
        }
        private void Entry1NameLink_Click(object sender, EventArgs e){
            TextInputDialog dialog = DialogFactory.GetHeaderDialog(Entry1NameLabel.Text);
            dialog.Validator = ValidateHeaderName;

            dialog.ShowDialog();

            if (dialog.NameValidated) {
                Entry1NameLabel.Text = dialog.InputText;
            }
        }

        //Entry2
        private void Entry2CopyPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Entry2PasswordTextBoxPanel.Text.SetToClipBoard();
        }
        private void Entry2NameLink_Click(object sender, EventArgs e){
            TextInputDialog dialog = DialogFactory.GetHeaderDialog(Entry2NameLabel.Text);
            dialog.Validator = ValidateHeaderName;

            dialog.ShowDialog();

            if (dialog.NameValidated) {
                Entry2NameLabel.Text = dialog.InputText;
            }
        }

        private bool ValidateHeaderName(string name){
            return !string.IsNullOrEmpty(name.Trim());
        }

        //Generator
        private void GeneratePasswordButton_Click(object sender, EventArgs e){
            int length = (int)PasswordLengthUpDown.Value;

            GeneratedTextBoxPanel.Text = StringGenerator.GenerateString(length);
        }
        private void CopyGeneratedPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            GeneratedTextBoxPanel.Text.SetToClipBoard();
        }

        //CheckBox
        private void EditableCheckBox_CheckedChanged(object sender, EventArgs e){
            SetEditability(EditableCheckBox.Checked);
        }

        //Buttons
        private bool ActivateSave() {
            bool validName = Validator.Invoke(NameTextBoxPanel.Text, File);

            if (validName) {
                File.Update(GetFile());
                CanBeSaved = true;

                return true;
            } else {
                DialogFactory.ShowShortErrorDialog("Invalid file name. It must not be empty.");

                return false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e){
            if (ActivateSave()) {
                Close();
            }
        }
        private void CancelButton_Click(object sender, EventArgs e){
            _cancel = true;

            Close();
        }
        private bool _cancel = false;

        private void FileDialog_FormClosing(object sender, FormClosingEventArgs e){
            if (CanBeSaved || _cancel) return;
            if (File.Equals(GetFile())) return;

            ConfirmationDialog dialog = DialogFactory.ShowSaveDialog();

            if (dialog.Confirmation == ConfirmationType.Yes) {
                if (!ActivateSave()) {
                    e.Cancel = true;
                }
            } else if (dialog.Confirmation == ConfirmationType.Cancel) {
                e.Cancel = true;
            }
        }
    }
}