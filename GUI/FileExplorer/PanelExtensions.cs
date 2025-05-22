using System;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;

namespace GUI {
    public static class PanelExtensions {
        public static void DoubleBuffered(this DataGridView dgv, bool setting){
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
        public static void StripSeparator_Paint(object sender, PaintEventArgs e){
            ToolStripSeparator stripSeparator = sender as ToolStripSeparator;
            ContextMenuStrip menuStrip = stripSeparator.Owner as ContextMenuStrip;

            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 45)), new Rectangle(0, 0, stripSeparator.Width, stripSeparator.Height));
            using (Pen pen = new Pen(Color.LightGray, 1)) {
                e.Graphics.DrawLine(pen, new Point(0, stripSeparator.Height / 2), new Point(menuStrip.Width, stripSeparator.Height / 2));
            }
        }
        public static void PaintBorderlessGroupBox(object sender, PaintEventArgs p){
            CustomGroupBox box = (CustomGroupBox)sender;

            Brush textBrush = new SolidBrush(box.ForeColor);
            Brush borderBrush = new SolidBrush(box.BorderColor);
            Pen borderPen = new Pen(borderBrush);
            SizeF strSize = p.Graphics.MeasureString(box.Text, box.Font);
            Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                           box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                           box.ClientRectangle.Width - 1,
                                           box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Clear text and border
            p.Graphics.Clear(box.Parent.BackColor);

            // Draw text
            p.Graphics.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

            // Drawing Border
            //Left
            p.Graphics.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            //Right
            p.Graphics.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Bottom
            p.Graphics.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Top1
            p.Graphics.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
            //Top2
            p.Graphics.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
        }
    }

    class MyToolStripRenderer : ToolStripProfessionalRenderer {
        public MyToolStripRenderer(Color selectionColor, Color itemBorderColor, Color arrowColor )
            : base(new MyColorTable(selectionColor, itemBorderColor)) {

            ArrowColor = arrowColor;
        }

        public Color ArrowColor { get; set; }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            var tsMenuItem = e.Item as ToolStripMenuItem;
            if (tsMenuItem != null)
                e.ArrowColor = ArrowColor;
            base.OnRenderArrow(e);
        }
    }
    class MyColorTable : ProfessionalColorTable {
        public Color _selectionColor;
        public Color _itemBorderColor;

        public MyColorTable(Color selectionColor, Color itemBorderColor) {
            _selectionColor = selectionColor;
            _itemBorderColor = itemBorderColor;
        }

        public override Color MenuItemSelected => _selectionColor;
        public override Color MenuItemBorder => _itemBorderColor;
    }
}
