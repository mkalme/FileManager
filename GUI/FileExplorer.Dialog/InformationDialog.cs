using System;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI {
    public partial class InformationDialog : Form {
        private Assembly CurrentAssembly = Assembly.GetExecutingAssembly();

        public InformationDialog()
        {
            InitializeComponent();

            Display();
        }

        private void InformationDialog_Shown(object sender, EventArgs e){
            KeyHistoryGrid.ClearSelection();

            BuildTitleLabel.Focus();
        }

        private void Display(){
            NameTextBoxPanel.Text = CurrentAssembly.GetName().Name;
            VersionTextBoxPanel.Text = CurrentAssembly.GetName().Version.ParseVersion();
            VersionReleasedTextBoxPanel.Text = GetAttributes().InformationalVersion;

            CurrentKeyTextBoxPanel.Text = ApplicationInfo.Current.KeyHistory.GetLastDate().ToString();

            FileManagerTextBoxPanel.Text = ApplicationInfo.Current.Created.ToString();
            LocatedTextBoxPanel.Text = Path.GetDirectoryName(ManagerInfo.ManagerPath);

            DisplayKeyHistoryGrid(ApplicationInfo.Current.KeyHistory.ChangedDates);
        }
        private AssemblyInformationalVersionAttribute GetAttributes() {
            var attr = Attribute
                .GetCustomAttribute(
                    Assembly.GetEntryAssembly(),
                    typeof(AssemblyInformationalVersionAttribute))
                as AssemblyInformationalVersionAttribute;

            return attr;
        }

        private void DisplayKeyHistoryGrid(IList<DateTime> dates) {
            KeyHistoryGrid.Rows.Clear();

            for (int i = 0; i < dates.Count; i++) {
                KeyHistoryGrid.Rows.Add(dates[i].ToString());

                ((TextAndImageCell)KeyHistoryGrid.Rows[i].Cells[0]).Image = Properties.Resources._22pxKey;
            }

            KeyHistoryGrid.ClearSelection();
        }
        private void KeyHistoryGrid_MouseDown(object sender, MouseEventArgs e){
            var hitTest = KeyHistoryGrid.HitTest(e.X, e.Y);

            if (hitTest.Type != DataGridViewHitTestType.Cell &&
                hitTest.Type != DataGridViewHitTestType.ColumnHeader) {
                KeyHistoryGrid.ClearSelection();
                return;
            }
        }
        private void CopyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            IList<DateTime> dates = ApplicationInfo.Current.KeyHistory.ChangedDates;

            string[] lines = new string[dates.Count];
            for (int i = 0; i < dates.Count; i++) {
                lines[i] = dates[i].ToString();
            }

            ViewHelper.SetToClipBoard(string.Join("\n", lines));
        }

        private void FileExplorerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            Process.Start(Path.GetDirectoryName(ManagerInfo.ManagerPath));
        }

        private void CloseButton_Click(object sender, EventArgs e){
            Close();
        }
    }
}
