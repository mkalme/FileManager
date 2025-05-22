using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class TextInputDialog : Form {
        public string InputText {
            get => InputTextBoxPanel.Text;
            set {
                InputTextBoxPanel.Text = value;
            }
        }
        public Image Image {
            get => IconPictureBox.Image;
            set {
                IconPictureBox.Image = value;
            }
        }
        public string Message {
            get => MessageLabel.Text;
            set {
                MessageLabel.Text = value;
            }
        }
        public delegate bool InputValidator(string input);
        public InputValidator Validator { get; set; }

        private bool _nameValidated = false;
        public bool NameValidated => _nameValidated;

        public TextInputDialog(string input, InputValidator validator = null){
            InitializeComponent();

            InputText = input;
            Validator = validator;
        }

        private void DoneButton_Click(object sender, EventArgs e){
            if (Validator == null) {
                _nameValidated = true;
                Close();
            } else {
                if (Validator.Invoke(InputTextBoxPanel.Text)) {
                    _nameValidated = true;
                    Close();
                }
            }
        }
    }
}
