using System;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing;
using System.Windows.Forms;
using FileManager;
using AesEncryption;

namespace GUI {
    public partial class FileExplorer : UserControl {
        private ExplorerProfile Profile { get; set; }
        private FileDirectory CurrentDirectory => Profile.CurrentView.Directory;
        private Item SelectedItem {
            get {
                if (ExplorerGrid.SelectedRows.Count < 1) return null;

                int index = (int)ExplorerGrid.SelectedRows[0].Cells[0].Value;
                return Profile.CurrentView.Items[index];
            }
        }

        public FileExplorer(ExplorerProfile profile)
        {
            InitializeComponent();
            InitializeUserComponent();

            Profile = profile;
            Profile.Update += new EventHandler(ProfileOnUpdate);

            DisplayExplorer(Profile.CurrentView);
        }
        private void InitializeUserComponent() {
            //PathPanel
            PathPanel.DirectoryClick += new EventHandler(PathPanelDirectoryClick);

            //ExplorerGrid
            ExplorerGrid.DoubleBuffered(true);

            var creationDateCol = ExplorerGrid.Columns["LastEditedCol"];
            creationDateCol.DefaultCellStyle.Format = "MMM dd, yyyy";
            creationDateCol.DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;

            ExplorerGrid.Columns["PasswordLength"].DefaultCellStyle.Format = "N0";

            //ExplorerGridMenuStrip
            ExplorerGridMenuStrip.Renderer = new MyToolStripRenderer(Color.Gray, Color.Gray, Color.LightGray);

            NewSeperator.Paint += new PaintEventHandler(PanelExtensions.StripSeparator_Paint);
            NewWindowSeperator.Paint += new PaintEventHandler(PanelExtensions.StripSeparator_Paint);
            PasteSeperator.Paint += new PaintEventHandler(PanelExtensions.StripSeparator_Paint);
            DeleteSeperator.Paint += new PaintEventHandler(PanelExtensions.StripSeparator_Paint);

            //ToolTip
            ToolTip.SetToolTip(BackButton, "Go back");
            ToolTip.SetToolTip(ForwardButton, "Go forward");
            ToolTip.SetToolTip(UpArrowButton, "Go to the parent's directory");
            ToolTip.SetToolTip(RefreshButton, "Refresh");

            ToolTip.SetToolTip(InformationButton, "Information about the program");
            ToolTip.SetToolTip(ChangeKeyButton, "Change current key");

            ToolTip.SetToolTip(DeselectButton, "Clear selection");
            ToolTip.SetToolTip(ClearClipboardButton, "Clear clipboard");

            ToolTip.SetToolTip(CloseButton, "Close");
        }

        private void FileExplorer_Load(object sender, EventArgs e) {
            ExplorerGrid.ClearSelection();
        }

        //FileExplorer
        private void DisplayExplorer(View view) {
            PathPanel.SetPath(view.Directory);
            DisplayExplorerGrid(view);
            InformationLabel.Text = $"Total amount of items: {view.Items.Count}";
        }

        private void ProfileOnUpdate(object sender, EventArgs e) {
            DisplayExplorer(Profile.CurrentView);
        }

        //PathPanel
        private void PathPanelDirectoryClick(object sender, EventArgs e) {
            if (sender == null) return;

            Profile.Open(((PathButton)sender).Directory);
        }

        //ExplorerGrid
        private void DisplayExplorerGrid(View view) {
            _canUpdate = false;
            _cancelation.Reset();

            ExplorerGrid.Rows.Clear();
            for (int i = 0; i < view.Items.Count; i++) {
                Item item = view.Items[i];
                Type type = item.GetType();

                if (type == typeof(PasswordFile)) {
                    PasswordFile file = (PasswordFile)item;

                    ExplorerGrid.Rows.Add(
                        i,
                        file.Name,
                        file.Website,
                        file.Password.Length.ToString(),
                        file.Email,
                        file.ModificationDate
                    );
                } else {
                    ExplorerGrid.Rows.Add(i, item.Name, "", "", "", item.ModificationDate);
                }

                ((TextAndImageCell)ExplorerGrid.Rows[i].Cells[1]).Image = item.GetIcon();
            }

            //Selection
            ExplorerGrid.ClearSelection();
            ExplorerGrid.CurrentCell = null;
            SelectItem(view.SelectedItem);

            if (ExplorerGrid.SelectedRows.Count > 0) {
                ExplorerGrid.FirstDisplayedScrollingRowIndex = ExplorerGrid.SelectedRows[0].Index;
            }

            ActivateHover();

            _canUpdate = true;
        }
        private void SelectItem(Item item) {
            int id = Profile.CurrentView.GetItemIndex(item);

            foreach (DataGridViewRow row in ExplorerGrid.Rows) {
                if ((int)row.Cells[0].Value == id) {
                    row.Selected = true;

                    return;
                }
            }
        }
        private Item GetNextItem() {
            if (ExplorerGrid.Rows.Count < 2 || ExplorerGrid.SelectedRows.Count < 1) return null;

            DataGridViewRow row = ExplorerGrid.SelectedRows[0];

            int reminder = ExplorerGrid.Rows.Count - row.Index - 1;

            if (reminder > 0) row = ExplorerGrid.Rows[row.Index + 1];
            else row = ExplorerGrid.Rows[row.Index - 1];

            return Profile.CurrentView.Items[(int)row.Cells[0].Value];
        }

        private bool _canUpdate = true;
        private void ExplorerGrid_SelectionChanged(object sender, EventArgs e) {
            if (!_canUpdate) return;

            if (_cancelation.Cancel) {
                _cancelation.Cancel = false;

                _canUpdate = false;

                if (_cancelation.SelectedRow > -1) {
                    ExplorerGrid.Rows[_cancelation.SelectedRow].Selected = true;
                    _cancelation.Reset();
                } else {
                    ExplorerGrid.ClearSelection();
                }

                _canUpdate = true;

                return;
            }

            Profile.CurrentView.SelectedItem = SelectedItem;
        }

        private void ExplorerGrid_MouseDown(object sender, MouseEventArgs e) {
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
                return;
            }
        }
        private void ExplorerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            OpenItem(SelectedItem);
        }

        private void ActivateHover() {
            Point cursor = ExplorerGrid.PointToClient(Cursor.Position);

            var hitTest = ExplorerGrid.HitTest(cursor.X, cursor.Y);
            if (hitTest.RowIndex > -1) {
                ExplorerGrid_CellMouseEnter(ExplorerGrid, new DataGridViewCellEventArgs(hitTest.ColumnIndex, hitTest.RowIndex));
            }
        }

        //Sort
        private void ExplorerGrid_Sorted(object sender, EventArgs e) {
            Profile.CurrentView.Sort = ExplorerGrid;
            Profile.CurrentView.SortItems();
        }

        private Cancelation _cancelation = new Cancelation();
        private void ExplorerGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.RowIndex < 0 && e.Button == MouseButtons.Left) {
                int count = ((DataGridView)sender).SelectedRows.Count;

                if (count > 0) {
                    int index = ExplorerGrid.SelectedRows[0].Index;

                    _cancelation = new Cancelation(index, true);
                    return;
                }

                _cancelation = new Cancelation(-1, true);
                return;
            }
        }

        //Hover
        private void ExplorerGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            ExplorerGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
        }
        private void ExplorerGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            ExplorerGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
        }

        //Methods
        private void OpenItem(Item item) {
            if (item == null) return;
            Type type = item.GetType();

            if (type == typeof(FileDirectory)) {
                Profile.Open((FileDirectory)item);
            } else if (type == typeof(PasswordFile)) {
                OpenFile((PasswordFile)item);
            } else if (type == typeof(Document)) {
                OpenDocument((Document)item);
            }
        }
        private void OpenFile(PasswordFile file) {
            FileDialog dialog = new FileDialog(file, ValidateName);
            dialog.ShowDialog();

            if (dialog.CanBeSaved) Save();
        }
        private void OpenDocument(Document document) {
            DocumentDialog dialog = new DocumentDialog(document);
            dialog.ShowDialog();

            if (dialog.CanBeSaved) Save();
        }

        private bool ValidateName(string name, Item obj) {
            if (string.IsNullOrEmpty(name)) return false;

            Type type = obj.GetType();

            List<Item> items = Profile.CurrentView.Items;
            foreach (var item in items) {
                if (item.GetType() != type) continue;

                if (item.Name != name) continue;
                if (item.Name == obj.Name) continue;

                return false;
            }

            return true;
        }
        private void Save() {
            ManagerInfo.Save();
        }

        private void CreateDirectory(string name) {
            FileDirectory directory = new FileDirectory(name);

            CurrentDirectory.Add(directory);
            Save();

            SelectItem(directory);
        }
        private void CreateFile(string name) {
            PasswordFile file = new PasswordFile(name);
            CurrentDirectory.Add(file);
            Save();

            SelectItem(file);

            OpenFile(file);
        }
        private void CreateDocument(string name) {
            Document document = new Document(name);
            CurrentDirectory.Add(document);
            Save();

            SelectItem(document);

            OpenDocument(document);
        }

        private void NewWindow(FileDirectory directory) {
            if (directory == null) return;

            new Window(directory).Show();
        }

        private void Paste(FileDirectory directory, Item item) {
            if (item == null) return;

            if (item.GetType() == typeof(FileDirectory)) {
                if (directory.IsSubDirectoryOf((FileDirectory)item)) {
                    DialogFactory.ShowShortErrorDialog("The directory cannot be copied to one of its sub-directories.");
                    return;
                }
            }


            Item clone = item.Clone();
            clone.Name = directory.GetNewItemName(item.GetType(), item.Name);

            directory.Add(clone);
            Save();

            SelectItem(clone);
        }

        private void MoveItem(Item item) {
            if (item == null) return;

            SelectDirectoryDialog dialog = DialogFactory.GetMoveDialog(Profile.CurrentView.Directory, item);
            dialog.ShowDialog();

            if (!dialog.Selected) return;
            if (Object.ReferenceEquals(CurrentDirectory, dialog.SelectedDirectory)) return;

            if (item.GetType() == typeof(FileDirectory)) {
                if (dialog.SelectedDirectory.IsSubDirectoryOf((FileDirectory)item)) {
                    DialogFactory.ShowShortErrorDialog("The directory cannot be moved to one of its sub-directories.");
                    return;
                }
            }

            CurrentDirectory.Remove(item);

            item.Name = dialog.SelectedDirectory.GetNewItemName(item.GetType(), item.Name);
            dialog.SelectedDirectory.Add(item);

            Save();
        }
        private void Rename(Item item) {
            if (item == null) return;

            TextInputDialog dialog = DialogFactory.ShowRenameDialog(item.Name, new ItemNameValidator(Profile, item));

            if (dialog.NameValidated) {
                item.Name = dialog.InputText;
                Save();
            }
        }
        private void Delete(Item item) {
            if (item == null) return;

            Item nextItem = GetNextItem();

            Profile.CurrentView.Directory.Remove(item);
            Save();

            SelectItem(nextItem);
        }

        private void OpenProperties(Item item) {
            if (item == null) return;

            Type type = item.GetType();

            if (type == typeof(FileDirectory)) {
                new DirectoryPropertyDialog((FileDirectory)item).ShowDialog();
            } else if (type == typeof(PasswordFile)) {
                new FilePropertyDialog((PasswordFile)item).ShowDialog();
            } else {
                new DocumentPropertyDialog((Document)item).ShowDialog();
            }
        }

        //Activations
        private void ActivateChangePassword() {
            Item selectedItem = SelectedItem;
            if (selectedItem == null) return;
            if (selectedItem.GetType() != typeof(PasswordFile)) return;

            PasswordFile file = (PasswordFile)selectedItem;

            var dialog = DialogFactory.ShowNewPasswordDialog(file.Password);

            if (!dialog.Selected) return;
            if (dialog.Password == file.Password) {
                DialogFactory.ShowShortErrorDialog("The password is the same.");
                return;
            }

            file.Password = dialog.Password;
            Save();
        }
        private void ActivateNewWindow() {
            FileDirectory directory = CurrentDirectory;

            Item selectedItem = SelectedItem;
            if (selectedItem != null) {
                if (selectedItem.GetType() == typeof(FileDirectory)) {
                    directory = (FileDirectory)selectedItem;
                }
            }

            NewWindow(directory);
        }
        private void ActivateCopy() {
            Profile.ClipboardItem = SelectedItem;
        }
        private void ActivatePaste() {
            FileDirectory directory = CurrentDirectory;

            Item selectedItem = SelectedItem;
            if (selectedItem != null) {
                if (selectedItem.GetType() == typeof(FileDirectory)) {
                    directory = (FileDirectory)selectedItem;
                }
            }

            Paste(directory, Profile.ClipboardItem);
        }
        private void ActivateDelete() {
            Item item = SelectedItem;
            if (item == null) return;

            ConfirmationDialog dialog = DialogFactory.ShowDeleteDialog();

            if (dialog.Confirmation == ConfirmationType.Yes) {
                Delete(item);
            }
        }
        private void ActivateChangeCurrentKey() {
            Key currentKey = ApplicationInfo.Current.Key;

            //CurrentKey
            var currentKeyDialog = DialogFactory.ShowCurrentKeyDialog();

            if (!currentKeyDialog.Selected) return;
            if (!currentKey.Compare(currentKeyDialog.Key)) {
                DialogFactory.ShowShortErrorDialog("The key is incorrect.");
                return;
            }

            //NewKey
            var newKeydialog = new NewKeyDialog();
            newKeydialog.ShowDialog();

            if (!newKeydialog.Selected) return;
            if (currentKey.Compare(newKeydialog.Key)) {
                DialogFactory.ShowShortErrorDialog("The key is the same.");
                return;
            }

            //Confirmation
            var confirmationDialog = DialogFactory.ShowChangeKeyDialog();

            if (confirmationDialog.Confirmation == ConfirmationType.Yes) {
                ApplicationInfo.Current.ChangeKey(newKeydialog.Key);

                Save();
                ApplicationInfo.Current.SaveToLocalFile();
            }
        }
        private void ActivateInforamtionDialog() {
            InformationDialog dialog = new InformationDialog();
            dialog.ShowDialog();
        }

        //ToolBar Buttons
        private void BackButton_Click(object sender, EventArgs e) {
            Profile.Prev();
        }
        private void ForwardButton_Click(object sender, EventArgs e) {
            Profile.Next();
        }

        private void UpArrowButton_Click(object sender, EventArgs e){
            Profile.Up();
        }
        private void RefreshButton_Click(object sender, EventArgs e) {
            Profile.CurrentView.Refresh();
        }

        //ExplorerGridMenuStrip
        private void ExplorerGridMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e) {
            Item selectedItem = SelectedItem;
            bool selected = selectedItem != null;

            if (selected) {
                NewWindowStripItem.Enabled = selectedItem.GetType() == typeof(FileDirectory);

                bool isFile = selectedItem.GetType() == typeof(PasswordFile);
                ChangePasswordStripItem.Enabled = isFile;
                ChangePasswordStripItem.Visible = isFile;
            } else {
                NewWindowStripItem.Enabled = true;
                ChangePasswordStripItem.Visible = false;
            }

            CopyStripItem.Enabled = selected;
            PasteStripItem.Enabled = Profile.ClipboardItem != null;

            MoveStripitem.Enabled = selected;
            RenameStripitem.Enabled = selected;
            DeleteStripitem.Enabled = selected;
        }

        private void DirectoryStripItem_Click(object sender, EventArgs e) {
            CreateDirectory(CurrentDirectory.GetNewItemName(typeof(FileDirectory), "New directory"));
        }
        private void FileStripitem_Click(object sender, EventArgs e) {
            CreateFile(CurrentDirectory.GetNewItemName(typeof(PasswordFile), "New file"));
        }
        private void DocumentStrimitem_Click(object sender, EventArgs e) {
            CreateDocument(CurrentDirectory.GetNewItemName(typeof(Document), "New document"));
        }

        private void ChangePasswordStripItem_Click(object sender, EventArgs e){
            ActivateChangePassword();
        }

        private void NewWindowStripItem_Click(object sender, EventArgs e) {
            ActivateNewWindow();
        }

        private void CopyStripItem_Click(object sender, EventArgs e) {
            ActivateCopy();
        }
        private void PasteStripItem_Click(object sender, EventArgs e) {
            ActivatePaste();
        }

        private void MoveStripitem_Click(object sender, EventArgs e) {
            MoveItem(SelectedItem);
        }
        private void RenameStripitem_Click(object sender, EventArgs e) {
            Rename(SelectedItem);
        }
        private void DeleteStripitem_Click(object sender, EventArgs e) {
            ActivateDelete();
        }

        private void PropertiesStripItem_Click(object sender, EventArgs e) {
            Item item = SelectedItem;
            if (item == null) {
                item = CurrentDirectory;
            }

            OpenProperties(item);
        }

        //Footer Tool Panel
        public event EventHandler ClosePanel;
        private void CloseButton_Click(object sender, EventArgs e) {
            if (ClosePanel != null)
                ClosePanel.Invoke(this, EventArgs.Empty);
        }

        private void ClearClipboardButton_Click(object sender, EventArgs e) {
            ViewHelper.SetToClipBoard("");
        }
        private void DeselectButton_Click(object sender, EventArgs e) {
            ExplorerGrid.ClearSelection();
        }

        private void ChangeKeyButton_Click(object sender, EventArgs e) {
            ActivateChangeCurrentKey();
        }
        private void ChangeThemeButton_Click(object sender, EventArgs e) {

        }
        private void InformationButton_Click(object sender, EventArgs e) {
            ActivateInforamtionDialog();
        }

        //Key Down
        private void ExplorerGrid_KeyDown(object sender, KeyEventArgs e) {
            Keys k = e.KeyCode;

            if (e.Control && k == Keys.C) {
                ActivateCopy();
            } else if (e.Control && k == Keys.V) {
                ActivatePaste();
            } else if (k == Keys.Back) {
                Profile.Prev();
            } else if (e.Shift && k == Keys.Up) {
                Profile.Up();
            } else if (k == Keys.Delete) {
                ActivateDelete();
            }
        }
    }

    class Cancelation{
        public int SelectedRow { get; set; } = -1;
        public bool Cancel { get; set; } = false;

        public Cancelation() { 
        }
        public Cancelation(int selectedRow, bool cancel) {
            SelectedRow = selectedRow;
            Cancel = cancel;
        }

        public void Reset() {
            SelectedRow = -1;
            Cancel = false;
        }
    }

    public class ItemNameValidator {
        public ExplorerProfile Profile { get; set; }
        public Item Item { get; set; }

        public ItemNameValidator(ExplorerProfile profile, Item item) {
            Profile = profile;
            Item = item;
        }

        public bool ValidateName(string name){
            if (string.IsNullOrEmpty(name)) return false;

            Type type = Item.GetType();

            List<Item> items = Profile.CurrentView.Items;
            foreach (var item in items) {
                if (item.GetType() != type) continue;

                if (item.Name == name) return false;
            }

            return true;
        }
    }
}
