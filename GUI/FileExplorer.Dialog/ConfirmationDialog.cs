using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GUI {
    public partial class ConfirmationDialog : Form {
        public ConfirmationType Confirmation { get; set; } = ConfirmationType.Cancel;
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

                int length = (int)Graphics.MeasureString(value, MessageLabel.Font).Width + 100;

                int minLength = FlowPanel.Width + 35;
                if (length < minLength) length = minLength;

                Width = length;
            }
        }
        public SystemSound Sound { get; set; } = SystemSounds.Asterisk;
        public string YesButtonText {
            get => YesButton.Text;
            set {
                YesButton.Text = value;
            }
        }
        public string NoButtonText {
            get => NoButton.Text;
            set {
                NoButton.Text = value;
            }
        }
        public string CancelButtonText {
            get => CancelDialogButton.Text;
            set {
                CancelDialogButton.Text = value;
            }
        }

        private Graphics Graphics { get; set; }

        public ConfirmationDialog(ConfirmationDialogType type, string message = ""){
            InitializeComponent();
            InitializeUserComponent(type);

            Graphics = CreateGraphics();

            MessageLabel.Text = message;
        }
        private void InitializeUserComponent(ConfirmationDialogType type) {
            NoButton.Visible = type == ConfirmationDialogType.YesNo || type == ConfirmationDialogType.YesNoCancel;
            CancelDialogButton.Visible = type == ConfirmationDialogType.YesCancel || type == ConfirmationDialogType.YesNoCancel;
        }

        private void ConfirmationDialog_Load(object sender, EventArgs e){
            Sound.Play();
        }

        private void YesButton_Click(object sender, EventArgs e){
            Confirmation = ConfirmationType.Yes;

            Close();
        }
        private void NoButton_Click(object sender, EventArgs e){
            Confirmation = ConfirmationType.No;

            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e){
            Confirmation = ConfirmationType.Cancel;

            Close();
        }
    }

    public enum ConfirmationDialogType {
        YesNo,
        YesNoCancel,
        YesCancel
    }
    public enum ConfirmationType { 
        Yes,
        Cancel,
        No,
    }
}
