using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Panel {
    public partial class RichTextBoxPanel : UserControl {
        public Font TextFont { get => RichTextBox.Font; set => RichTextBox.Font = value; }
        public Color TextColor { get => RichTextBox.ForeColor; set => RichTextBox.ForeColor = value; }
        public string InputText { get => RichTextBox.Text; set => RichTextBox.Text = value; }
        public bool ReadOnly {
            get { return RichTextBox.ReadOnly; }
            set {
                RichTextBox.ReadOnly = value;

                if (value) {
                    RichTextBox.ForeColor = Color.FromArgb(145, 145, 145);

                    BackColor = Color.FromArgb(52, 52, 52);
                    RichTextBox.BackColor = BackColor;
                } else {
                    RichTextBox.ForeColor = SystemColors.HighlightText;

                    BackColor = Color.FromArgb(45, 45, 45);
                    RichTextBox.BackColor = BackColor;
                }
            }
        }
        public Color PanelBackColor {
            get => BackColor;
            set {
                BackColor = value;
                RichTextBox.BackColor = value;
            }
        }

        public RichTextBoxPanel()
        {
            InitializeComponent();
        }
    }
}
