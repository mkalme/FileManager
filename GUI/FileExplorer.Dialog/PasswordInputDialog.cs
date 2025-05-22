using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class PasswordInputDialog : Form {
        public string Password { get => PasswordTextBoxPanel.Text; set => PasswordTextBoxPanel.Text = value; }
        
        private bool _selected = false;
        public bool Selected { get => _selected; }

        public PasswordInputDialog(string password = ""){
            InitializeComponent();
            InitializeUserComponent();

            PasswordTextBoxPanel.Text = password;
        }
        private void InitializeUserComponent(){
            ToolTip.SetToolTip(CopyTextButton, "Copy key");
            ToolTip.SetToolTip(PasteButton, "Paste key");
        }

        private void PasswordInputDialog_Shown(object sender, EventArgs e){
            GeneratePasswordButton.Focus();
        }

        private void PasswordTextBoxPanel_TextChange(object sender, EventArgs e){
            CharactersLabel.Text = $"{PasswordTextBoxPanel.Text.Length} characters";
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e){
            int length = (int)PasswordLengthUpDown.Value;

            PasswordTextBoxPanel.Text = StringGenerator.GenerateString(length);
        }

        private void CopyTextButton_Click(object sender, EventArgs e){
            ViewHelper.SetToClipBoard(PasswordTextBoxPanel.Text);
        }
        private void PasteButton_Click(object sender, EventArgs e){
            PasswordTextBoxPanel.Text = Clipboard.GetText();
        }

        private void DoneButton_Click(object sender, EventArgs e){
            _selected = true;
            Close();
        }
    }
}
