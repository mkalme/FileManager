using System;
using System.Windows.Forms;
using FileManager;
using AesEncryption;

namespace GUI {
    public partial class Window : Form {
        public Window(FileDirectory directory)
        {
            InitializeComponent();

            FileExplorer explorer = new FileExplorer(new ExplorerProfile(directory));
            explorer.Dock = DockStyle.Fill;
            explorer.ClosePanel += PanelClose;

            Controls.Add(explorer);
        }

        private void PanelClose(object sender, EventArgs e) {
            Close();
        }
    }
}
