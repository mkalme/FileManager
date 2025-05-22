using System;
using System.Text;
using System.Windows.Forms;
using AesEncryption;

namespace GUI {
    public partial class KeyInputDialog : Form {
        public Key Key { get; set; }
        
        public string Message { get => KeyLabel.Text; set { KeyLabel.Text = value; } }

        private bool _selected = false;
        public bool Selected { get => _selected; }

        public KeyInputDialog(){
            InitializeComponent();
            InitializeUserComponent();
        }
        private void InitializeUserComponent(){
            ToolTip.SetToolTip(CopyTextButton, "Copy key");
            ToolTip.SetToolTip(PasteButton, "Paste key");
        }

        private void KeyInputDialog_Shown(object sender, EventArgs e){
            KeyTextBox.Focus();
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e){
            CharactersLabel.Text = $"{KeyTextBox.Text.Length} characters";
        }

        private void CopyTextButton_Click(object sender, EventArgs e){
            ViewHelper.SetToClipBoard(KeyTextBox.Text);
        }
        private void PasteButton_Click(object sender, EventArgs e){
            KeyTextBox.Text = Clipboard.GetText();
        }

        private void KeyInputDialog_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter) {
                ActivateDone();
            }
        }
        private void KeyTextBox_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter) {
                ActivateDone();
            }
        }

        private void ActivateDone() {
            try {
                Key = new Key(Encoding.ASCII.GetBytes(KeyTextBox.Text));
            } catch (Exception error) {
                DialogFactory.ShowShortErrorDialog(error.Message);

                return;
            }

            _selected = true;
            Close();
        }

        private void DoneButton_Click(object sender, EventArgs e){
            ActivateDone();
        }
    }
}
