using System;
using System.Windows.Forms;
using FileManager;

namespace GUI {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Key input
            KeyInputDialog dialog = new KeyInputDialog();
            dialog.ShowDialog();
            if (dialog.Key == null) Environment.Exit(1);

            //Create files
            try {
                ApplicationInfo.Current = ApplicationInfo.LoadFromLocalFile(dialog.Key);
                ManagerInfo.Current = ManagerInfo.LoadFromLocalFile(dialog.Key);
            } catch (Exception e) {
                DialogFactory.ShowErrorDialog(e);
                return;
            }

            //Show dialog
            try {
                Application.Run(new Window(ManagerInfo.Current));
            } catch (Exception e) {
                DialogFactory.ShowErrorDialog(e);
            }
        }
    }
}
