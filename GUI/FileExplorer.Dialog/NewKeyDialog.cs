using System;
using System.Text;
using System.Windows.Forms;
using AesEncryption;

namespace GUI {
    public partial class NewKeyDialog : Form {
        public Key Key { get; set; }

        private bool _selected = false;
        public bool Selected { get => _selected; }

        public NewKeyDialog(Key key = null){
            InitializeComponent();
            InitializeUserComponent();

            SetKey(key);
        }
        private void InitializeUserComponent() {
            ToolTip.SetToolTip(CopyTextButton, "Copy key");
            ToolTip.SetToolTip(PasteButton, "Paste key");
        }

        private void NewKeyDialog_Shown(object sender, EventArgs e){
            GenerateKeyButon.Focus();
        }

        private void SetKey(Key key) {
            if (key == null) return;

            KeyTextBox.Text = Encoding.ASCII.GetString(key.GetKey());
        }

        private void KeyTextBox_TextChanged(object sender, EventArgs e){
            CharactersLabel.Text = $"{KeyTextBox.Text.Length} characters";
        }

        private void GenerateKeyButton_Click(object sender, EventArgs e){
            SetKey(KeyGenerator.GenerateKey());
        }

        private void CopyTextButton_Click(object sender, EventArgs e){
            ViewHelper.SetToClipBoard(KeyTextBox.Text);
        }
        private void PasteButton_Click(object sender, EventArgs e){
            KeyTextBox.Text = Clipboard.GetText();
        }

        private void DoneButton_Click(object sender, EventArgs e){
            try {
                Key = new Key(Encoding.ASCII.GetBytes(KeyTextBox.Text));
            } catch (Exception error) {
                DialogFactory.ShowShortErrorDialog(error.Message);

                return;
            }

            _selected = true;
            Close();
        }
    }
}
