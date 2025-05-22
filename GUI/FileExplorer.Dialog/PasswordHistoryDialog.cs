using System;
using System.Globalization;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FileManager;

namespace GUI {
    public partial class PasswordHistoryDialog : Form {
        private PasswordFile File { get; set; }

        private int SelectedIndex {
            get {
                if (DateGrid.SelectedRows.Count < 1) return -1;
                return (int)DateGrid.SelectedRows[0].Cells[0].Value;
            }
        }

        public PasswordHistoryDialog(PasswordFile file) {
            InitializeComponent();
            InitializeUserComponent();

            File = file;

            DisplayGrid();
        }
        private void InitializeUserComponent() {
            MenuStrip.Renderer = new MyToolStripRenderer(Color.Gray, Color.Gray, Color.LightGray);
            DateGrid.DoubleBuffered(true);

            //ToolTip
            ToolTip.SetToolTip(AddButton, "Add new password edit date");
            ToolTip.SetToolTip(EditButton, "Edit selected date");
            ToolTip.SetToolTip(RemoveButton, "Remove selected password edit date");
        }

        private void PasswordHistoryDialog_Load(object sender, EventArgs e) {
            DateGrid.ClearSelection();
        }

        //DateGrid
        private void DisplayGrid() {
            DateGrid.Rows.Clear();

            IList<DateTime> dates = File.PasswordChangeHistory.Dates;
            for (int i = 0; i < dates.Count; i++) {
                DateGrid.Rows.Add(i, dates[i].ToString(), (DateTime.Now - dates[i]).ParseTimeSpan());

                ((TextAndImageCell)DateGrid.Rows[i].Cells[1]).Image = Properties.Resources._16pxGeneratePassword;
            }

            DateGrid.ClearSelection();
        }

        private void DateGrid_SelectionChanged(object sender, EventArgs e) {
            bool enabled = DateGrid.SelectedRows.Count > 0;

            EditButton.Enabled = enabled;
            RemoveButton.Enabled = enabled;
        }
        private void DateGrid_MouseDown(object sender, MouseEventArgs e) {
            var hitTest = DateGrid.HitTest(e.X, e.Y);

            if (hitTest.Type != DataGridViewHitTestType.Cell &&
                hitTest.Type != DataGridViewHitTestType.ColumnHeader) {
                DateGrid.ClearSelection();
                return;
            }

            if (e.Button == MouseButtons.Right) {
                if (hitTest.Type == DataGridViewHitTestType.ColumnHeader) return;

                DateGrid.ClearSelection();
                DateGrid.Rows[hitTest.RowIndex].Selected = true;
                return;
            }
        }

        //Hover
        private void DateGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            DateGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
        }
        private void DateGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            DateGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        //Methods
        private void Add() {
            string title = "New password edit date";
            string message = "Enter the new date";
            
            DateTime time = new DateTime(0);
            if (!DialogFactory.ShowDateInputDialog(title, message, ref time)) return;

            if (File.PasswordChangeHistory.Exists(time)) {
                DialogFactory.ShowShortErrorDialog("The edit date already exists.");
                return;
            }

            File.PasswordChangeHistory.Add(time);

            ManagerInfo.Save();
            DisplayGrid();
        }
        private void Edit(int index) {
            if (index < 0) return;

            string title = "Password date";
            string message = "Change password edit change";

            DateTime time = File.PasswordChangeHistory[index];
            if (!DialogFactory.ShowDateInputDialog(title, message, ref time)) return;

            if (File.PasswordChangeHistory.Exists(time)) {
                DialogFactory.ShowShortErrorDialog("The edit date already exists.");
                return;
            }

            File.PasswordChangeHistory[index] = time;
            
            ManagerInfo.Save();
            DisplayGrid();
        }
        private void Remove(int index) {
            if (index < 0) return;

            ConfirmationDialog dialog = DialogFactory.ShowRemoveDialog();

            if (dialog.Confirmation == ConfirmationType.Yes) {
                File.PasswordChangeHistory.RemoveAt(index);

                ManagerInfo.Save();
                DisplayGrid();
            }
        }

        //MenuStripSeperator
        private void MenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            int selectedIndex = SelectedIndex;

            EditStripItem.Enabled = selectedIndex > -1;
            RemoveStripItem.Enabled = selectedIndex > -1;
        }

        private void AddStripItem_Click(object sender, EventArgs e) {
            Add();
        }
        private void EditStripItem_Click(object sender, EventArgs e) {
            Edit(SelectedIndex);
        }
        private void RemoveStripItem_Click(object sender, EventArgs e) {
            Remove(SelectedIndex);
        }

        //Buttons
        private void AddButton_Click(object sender, EventArgs e) {
            Add();
        }
        private void EditButton_Click(object sender, EventArgs e) {
            Edit(SelectedIndex);
        }
        private void RemoveButton_Click(object sender, EventArgs e) {
            Remove(SelectedIndex);
        }
    }
}
