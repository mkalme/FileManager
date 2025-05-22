using System;
using System.Media;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class MessageDialog : Form {
        public Image Image {
            get => IconPictureBox.Image;
            set {
                IconPictureBox.Image = value;
            }
        }
        public string Message {
            get => RichTextBox.Text;
            set {
                RichTextBox.Text = value;

                ResizeForm(value);
            }
        }
        public SystemSound Sound { get; set; } = SystemSounds.Asterisk;
        public BorderStyle TextBorderStyle {
            get => TextPanel.BorderStyle;
            set => TextPanel.BorderStyle = value;
        }
        
        private bool _sizeable = true;
        public bool Sizeable {
            get => _sizeable;
            set {
                _sizeable = value;

                if (value) {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    MaximizeBox = true;
                } else {
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    MaximizeBox = false;
                }
            }
        }

        private Graphics Graphics { get; set; }

        public MessageDialog(string message = "") {
            InitializeComponent();

            Graphics = CreateGraphics();

            Message = message;
        }

        private void ResizeForm(string text) {
            int length = (int)Graphics.MeasureString(text, RichTextBox.Font).Width;

            length = Math.Min(Math.Max(length, 250), 500);

            SizeF size = Graphics.MeasureString(text, RichTextBox.Font, length);
            length = size.Width > length ? (int)size.Width : length;

            Width = length + 100;
            Height = (int)size.Height + 100;
        }

        private void MessageDialog_Load(object sender, EventArgs e){
            Sound.Play();

        }
        private void MessageDialog_Shown(object sender, EventArgs e){
            OkButton.Focus();
        }

        private void OkButton_Click(object sender, EventArgs e){
            Close();
        }
    }
}
