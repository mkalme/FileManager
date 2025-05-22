using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using FileManager;

namespace GUI {
    public partial class SelectDirectoryDialog : Form {
        private ExplorerProfile Profile { get; set; }
        private Item SelectedItem {
            get {
                if (ExplorerGrid.SelectedRows.Count < 1) return null;

                int index = (int)ExplorerGrid.SelectedRows[0].Cells[0].Value;
                return Profile.CurrentView.Items[index];
            }
        }
        private FileDirectory PrevDirectory { get; set; }

        public FileDirectory SelectedDirectory { get; set; }
        public Item DiscardItem { get; set; }

        public bool Selected { get; set; } = false;

        public SelectDirectoryDialog(FileDirectory directory, Item discardItem = null){
            InitializeComponent();
            InitializeUserComponent();

            DiscardItem = discardItem;

            Profile = new ExplorerProfile(directory);
            Profile.Update += new EventHandler(ProfileOnUpdate);

            DisplayDialog(Profile.CurrentView);
        }
        private void InitializeUserComponent(){
            //PathPanel
            PathPanel.DirectoryClick += new EventHandler(PathPanelDirectoryClick);

            //ExplorerGrid
            ExplorerGrid.DoubleBuffered(true);

            var creationDateCol = ExplorerGrid.Columns["LastEditedCol"];
            creationDateCol.DefaultCellStyle.Format = "MMM dd, yyyy";
            creationDateCol.DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;

            //ToolTip
            ToolTip.SetToolTip(UpArrowButton, "Go to the parent");
            ToolTip.SetToolTip(ForwardButton, "Forward");
        }

        private void SelectDirectoryDialog_Load(object sender, EventArgs e){
            ExplorerGrid.ClearSelection();
        }

        //SelectDirectoryDialog
        private void DisplayDialog(View view) {
            view.DiscardItem(DiscardItem);

            PathPanel.SetPath(view.Directory);
            DisplayExplorerGrid(view);
        }

        private void ProfileOnUpdate(object sender, EventArgs e){
            DisplayDialog(Profile.CurrentView);
        }

        //PathPanel
        private void PathPanelDirectoryClick(object sender, EventArgs e){
            if (sender == null) return;

            Profile.Open(((PathButton)sender).Directory);
        }

        //ExplorerGrid
        private void DisplayExplorerGrid(View view){
            _canUpdate = false;

            ExplorerGrid.Rows.Clear();
            for (int i = 0; i < view.Items.Count; i++) {
                Item item = view.Items[i];
                Type type = item.GetType();

                if (type != typeof(FileDirectory)) continue;

                ExplorerGrid.Rows.Add(i, item.Name, item.ModificationDate);

                ((TextAndImageCell)ExplorerGrid.Rows[i].Cells[1]).Image = item.GetIcon();
            }

            //Selection
            ExplorerGrid.ClearSelection();
            ExplorerGrid.CurrentCell = null;
            
            if (view.NewlyCreated) {
                if (Profile.PrevView != null) {
                    view.SelectedItem = view.Directory.GetDirectoryFromSubDirectory(Profile.PrevView.Directory);
                }
            }

            SelectItem(view.SelectedItem);

            if (ExplorerGrid.SelectedRows.Count > 0) {
                ExplorerGrid.FirstDisplayedScrollingRowIndex = ExplorerGrid.SelectedRows[0].Index;
            }

            ActivateHover();

            _canUpdate = true;
        }
        private void SelectItem(Item item){
            int id = Profile.CurrentView.GetItemIndex(item);

            foreach (DataGridViewRow row in ExplorerGrid.Rows) {
                if ((int)row.Cells[0].Value == id) {
                    row.Selected = true;

                    return;
                }
            }
        }

        private bool _canUpdate = true;
        private void ExplorerGrid_SelectionChanged(object sender, EventArgs e){
            if (!_canUpdate) return;

            Profile.CurrentView.SelectedItem = SelectedItem;
        }

        private void ExplorerGrid_MouseDown(object sender, MouseEventArgs e){
            var hitTest = ExplorerGrid.HitTest(e.X, e.Y);

            if (hitTest.Type != DataGridViewHitTestType.Cell &&
                hitTest.Type != DataGridViewHitTestType.ColumnHeader) {
                ExplorerGrid.ClearSelection();
                return;
            }

            if (e.Button == MouseButtons.Right) {
                if (hitTest.Type == DataGridViewHitTestType.ColumnHeader) return;

                ExplorerGrid.ClearSelection();
                ExplorerGrid.Rows[hitTest.RowIndex].Selected = true;
            }
        }
        private void ExplorerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex < 0) return;

            OpenItem(SelectedItem);
        }

        private void ActivateHover(){
            Point cursor = ExplorerGrid.PointToClient(Cursor.Position);

            var hitTest = ExplorerGrid.HitTest(cursor.X, cursor.Y);
            if (hitTest.RowIndex > -1) {
                ExplorerGrid_CellMouseEnter(ExplorerGrid, new DataGridViewCellEventArgs(hitTest.ColumnIndex, hitTest.RowIndex));
            }
        }

        //Hover
        private void ExplorerGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex < 0) return;

            ExplorerGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
        }
        private void ExplorerGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex < 0) return;

            ExplorerGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
        }

        //Methods
        private void OpenItem(Item item){
            if (item == null) return;
            Type type = item.GetType();

            if (type == typeof(FileDirectory)) {
                Profile.Open((FileDirectory)item);
            }
        }

        //Left-Right Arrow buttons
        private void BackButton_Click(object sender, EventArgs e) {
            Profile.Up();
        }
        private void ForwardButton_Click(object sender, EventArgs e){
            Profile.Down();
        }

        //Buttons
        private void SelectButton_Click(object sender, EventArgs e){
            Selected = true;
            SelectedDirectory = Profile.CurrentView.Directory;

            Close();
        }
        private void CancelDialogButton_Click(object sender, EventArgs e){
            Close();
        }
    }
}
