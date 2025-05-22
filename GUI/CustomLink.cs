using System;
using System.Windows.Forms;
using System.Drawing;

namespace GUI {
    public class CustomLink : Label {
        private bool _enabled = true;
        public bool ClickEnabled {
            get => _enabled;
            set {
                _enabled = value;

                base.Cursor = value ? Cursors.Hand : Cursors.Arrow;
                base.ForeColor = value ? Color : DisabledColor;

                if (value) {
                    base.Font = new Font(base.Font, FontStyle.Underline);
                } else {
                    base.Font = new Font(base.Font, FontStyle.Regular);
                }
            }
        }
        public Color Color { get; set; } = SystemColors.HighlightText;
        public Color ActiveColor { get; set; } = Color.DimGray;
        public Color DisabledColor { get; set; } = Color.FromArgb(100, 100, 100);

        public CustomLink() {
            ClickEnabled = true;

            MouseDown += OnMouseDown;
            MouseUp += OnMouseUp;
            MouseHover += OnMouseHover;
        }

        private void OnMouseDown(object sender, EventArgs e) {
            if (!_enabled) return;

            ForeColor = ActiveColor;
        }
        private void OnMouseUp(object sender, EventArgs e){
            if (!_enabled) return;

            ForeColor = Color;
        }
        private void OnMouseHover(object sender, EventArgs e){
            base.Cursor = _enabled ? Cursors.Hand : Cursors.Arrow;
        }
    }
}
