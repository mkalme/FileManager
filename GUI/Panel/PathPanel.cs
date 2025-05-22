using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FileManager;

namespace GUI {
    public partial class PathPanel : UserControl {
        private List<PathButton> Buttons { get; set; } = new List<PathButton>();

        private Color _backColor;
        private Color _foreColor;

        public override Color BackColor {
            get => _backColor;
            set {
                _backColor = value;

                foreach (Control control in Controls) {
                    control.BackColor = value;
                }
            }
        }
        public override Color ForeColor {
            get => _foreColor;
            set {
                _foreColor = value;

                foreach (Control control in Controls) {
                    control.ForeColor = value;
                }
            }
        }

        public PathPanel(){
            InitializeComponent();
        }

        //Event
        public event EventHandler DirectoryClick;

        public void SetPath(FileDirectory directory) {
            Buttons.Clear();
            AddButtons(directory, CreateGraphics());
            AddControls();
        }

        private void AddButtons(FileDirectory directory, Graphics graphics){
            FileDirectory currentDirectory = directory;
            while (currentDirectory != null) {
                PathButton button = new PathButton(currentDirectory, graphics);
                button.BackColor = BackColor;
                button.ForeColor = ForeColor;

                Buttons.Insert(0, button);
                currentDirectory = currentDirectory.Parent;
            }
        }
        private void AddControls() {
            Controls.Clear();

            int x = 0;
            for (int i = 0; i < Buttons.Count; i++) {
                PathButton button = Buttons[i];
                button.Location = new Point(x, (Height - button.Height) / 2);
                button.Height = Height;

                Controls.Add(button);
                x += button.Width;

                if (i < Buttons.Count - 1) button.Click += DirectoryClick;
                button.BringToFront();

                //PathLabel
                if (i >= Buttons.Count - 1) return;

                PathLabel label = new PathLabel(">");
                label.Location = new Point(x -= 2, 1);
                label.ForeColor = ForeColor;

                Controls.Add(label);
                x += label.Width - 4;
            }
        }
    }

    class PathButton : Button {
        public FileDirectory Directory { get; set; }

        public PathButton(FileDirectory directory, Graphics graphics){
            InitializeComponent();

            Directory = directory;

            Text = Directory.Name;
            Width = (int)graphics.MeasureString(Text, Font).Width + 12;
        }

        private void InitializeComponent(){
            Font = new Font("Segoe UI", 9, FontStyle.Regular);
            ForeColor = SystemColors.HighlightText;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseDownBackColor = Color.FromArgb(65, 65, 65);
            FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
        }
    }

    class PathLabel : Label {
        public PathLabel(string text = ">"){
            InitializeComponent();

            Text = text;
        }

        private void InitializeComponent(){
            Font = new Font("Segoe UI", 10, FontStyle.Regular);
            ForeColor = SystemColors.HighlightText;
            AutoSize = true;
        }
    }
}
