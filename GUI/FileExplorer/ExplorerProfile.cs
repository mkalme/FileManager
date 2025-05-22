using System;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Windows.Forms;
using FileManager;
using AesEncryption;

namespace GUI {
    public class ExplorerProfile {
        private Item _clipboardItem;
        public Item ClipboardItem {
            get => _clipboardItem;
            set {
                if (_clipboardItem != null) {
                    _clipboardItem.Deleted -= OnClipboardDeleted;
                }

                if (value != null) {
                    _clipboardItem = value;
                    _clipboardItem.Deleted += OnClipboardDeleted;
                } else {
                    _clipboardItem = null;
                }
            }
        }

        private List<View> Views { get; set; }

        private int _currentIndex = -1;
        public View CurrentView => Views[_currentIndex];

        public View PrevView { get; set; }

        public ExplorerProfile(ExplorerProfile profile) {
            ClipboardItem = profile.ClipboardItem;

            Views = new List<View>();
            foreach (var view in profile.Views) {
                Views.Add(new View(view));
            }

            _currentIndex = profile._currentIndex;
        }
        public ExplorerProfile(FileDirectory directory) {
            Views = new List<View>();

            Open(directory);
        }

        //Event
        public event EventHandler Update;
        private void OnUpdate() {
            if (Update != null)
                Update.Invoke(Views[_currentIndex], EventArgs.Empty);
        }

        private void OnViewUpdate(object sender, EventArgs e) {
            OnUpdate();
        }
        private void OnViewDeleted(object sender, EventArgs e) {
            View view = (View)sender;
            int index = Views.FindIndex(x => Object.ReferenceEquals(x, view));
            if (index < 0) return;

            Views.RemoveRange(index, Views.Count - index);

            if (_currentIndex >= index) {
                _currentIndex = index - 1;
            }

            OnUpdate();
        }
        private void OnClipboardDeleted(object sender, EventArgs e) {
            _clipboardItem = null;
        }

        //Open
        public void Open(FileDirectory directory) {
            if (_currentIndex >= Views.Count - 1) {
                Views.Add(GetView(directory));

                RemoveCurrentView();
                _currentIndex++;
                SetCurrentView();

                return;
            }

            if (Views[_currentIndex].Equals(directory)) {
                RemoveCurrentView();
                SetCurrentView();

                return;
            }

            if (Views[_currentIndex + 1].Equals(directory)) {
                RemoveCurrentView();
                _currentIndex++;
                SetCurrentView();
                
                return;
            } else {
                Views.RemoveRange(_currentIndex + 1, Views.Count - _currentIndex - 1);

                Views.Add(GetView(directory));

                RemoveCurrentView();
                _currentIndex++;
                SetCurrentView();
            }
        }
        
        private void SetCurrentView() {
            CurrentView.Update += OnViewUpdate;

            CurrentView.Refresh();
        }
        private void RemoveCurrentView() {
            if (_currentIndex < 0) return;

            CurrentView.Update -= OnViewUpdate;

            CurrentView.NewlyCreated = false;
            PrevView = CurrentView;
        }
        private View GetView(FileDirectory directory) {
            View view = null;

            foreach (var v in Views) {
                if (Object.ReferenceEquals(v.Directory, directory)) {
                    view = v;
                    break;
                }
            }

            if (view == null) {
                view = new View(directory);
                view.Deleted += OnViewDeleted;
            }

            return view;
        }

        public void Prev() {
            if (_currentIndex < 1) return;

            RemoveCurrentView();
            _currentIndex--;
            SetCurrentView();
        }
        public void Next() {
            if (_currentIndex >= Views.Count - 1) return;

            RemoveCurrentView();
            _currentIndex++;
            SetCurrentView();
        }

        public void Up() {
            if (CurrentView.Directory.Parent == null) return;

            Open(CurrentView.Directory.Parent);
        }
        public void Down() {
            if (_currentIndex < 1) return;

            RemoveCurrentView();
            _currentIndex--;
            SetCurrentView();
        }
    }

    public class View {
        public FileDirectory Directory { get; set; }
        public List<Item> Items { get; set; }

        public Item SelectedItem { get; set; }
        public Sort Sort { get; set; } = new Sort();

        public bool NewlyCreated { get; set; } = true;

        public View(View view) {
            Directory = view.Directory;
            Items = GetSortedList(view.Directory.Items);
            SelectedItem = view.SelectedItem;
        }
        public View(FileDirectory directory) {
            Directory = directory;
            Items = GetSortedList(directory.Items);

            Directory.PropertyChange += OnDirectoryUpdate;
            Directory.ContentsChange += OnDirectoryUpdate;
            Directory.Deleted += OnDirectoryDeleted;
        }

        public static implicit operator View(FileDirectory directory){
            return new View(directory);
        }

        //Event
        public event EventHandler Update;
        private void OnUpdate(){
            if (Update != null)
                Update.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler Deleted;
        private void OnDeleted(){
            if (Deleted != null)
                Deleted.Invoke(this, EventArgs.Empty);
        }

        private void OnDirectoryUpdate(object sender, EventArgs e) {
            Refresh();
        }
        private void OnDirectoryDeleted(object sender, EventArgs e) {
            OnDeleted();
        }

        public void Refresh() {
            Items = SortList(Directory.Items, Sort);

            OnUpdate();
        }
        public int GetItemIndex(Item item) {
            if (item == null) return -1;

            for (int i = 0; i < Items.Count; i++) {
                if(Object.ReferenceEquals(item, Items[i])) return i;
            }

            return -1;
        }
        public void DiscardItem(Item item) {
            for (int i = 0; i < Items.Count; i++) {
                if (Object.ReferenceEquals(Items[i], item)) {
                    Items.RemoveAt(i);

                    return;
                }
            }
        }
        public void SortItems() {
            Items = SortList(Items, Sort);

            OnUpdate();
        }
        public bool Equals(FileDirectory directory){
            return Object.ReferenceEquals(Directory, directory);
        }

        //Sort
        private static List<Item> GetSortedList(IEnumerable<Item> list, bool fileFirst = false) {
            List<List<Item>> sortedList = new List<List<Item>>() { new List<Item>(), new List<Item>(), new List<Item>() };

            foreach (var item in list) {
                Type type = item.GetType();

                if (type == typeof(FileDirectory)) {
                    sortedList[fileFirst ? 1 : 0].Add(item);
                } else if (type == typeof(PasswordFile)) {
                    sortedList[fileFirst ? 0 : 1].Add(item);
                } else {
                    sortedList[2].Add(item);
                }
            }

            return sortedList[0].Concat(sortedList[1]).Concat(sortedList[2]).ToList();
        }
        private static List<Item> SortList(IEnumerable<Item> items, Sort sort) {
            IEnumerable<Item> output = items;

            bool fileFirst = false;
            switch (sort.ColIndex) {
                case 1:
                    output = items.OrderBy(x => x.Name);
                    break;
                case 2:
                    output = items.OrderBy(x => x.GetType() == typeof(PasswordFile) ? ((PasswordFile)x).Website : "");
                    fileFirst = true;
                    break;
                case 3:
                    output = items.OrderBy(x => x.GetType() == typeof(PasswordFile) ? ((PasswordFile)x).Password.Length : 0);
                    fileFirst = true;
                    break;
                case 4:
                    output = items.OrderBy(x => x.GetType() == typeof(PasswordFile) ? ((PasswordFile)x).Email : "");
                    fileFirst = true;
                    break;
                case 5:
                    output = items.OrderBy(x => x.ModificationDate);
                    break;
            }

            if (sort.Direction == ListSortDirection.Ascending) output = output.Reverse();

            return GetSortedList(output, fileFirst);
        }
    }

    public class Sort {
        public int ColIndex { get; set; } = -1;
        public ListSortDirection Direction { get; set; } = ListSortDirection.Descending;

        public Sort() { 
        }
        public Sort(int colIndex, ListSortDirection direction) {
            ColIndex = colIndex;
            Direction = direction;
        }

        public static implicit operator Sort(DataGridView dataGridView) {
            int colIndex = -1;
            if (dataGridView.SortedColumn != null) {
                colIndex = dataGridView.SortedColumn.Index;
            }

            ListSortDirection direction = ListSortDirection.Ascending;
            if (dataGridView.SortOrder == SortOrder.Ascending) {
                direction = ListSortDirection.Ascending;
            } else {
                direction = ListSortDirection.Descending;
            }

            return new Sort(colIndex, direction);
        }
    }
}
