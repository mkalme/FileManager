using System;
using System.Globalization;
using System.Drawing;
using System.Media;
using FileManager;

namespace GUI {
    public static class DialogFactory {
        public static TextInputDialog GetHeaderDialog(string input) {
            TextInputDialog dialog = new TextInputDialog(input);

            dialog.Text = "Rename header";
            dialog.Message = "Rename header";
            dialog.Image = Properties.Resources._64pxRename;
            dialog.Icon = Properties.Resources._64pxRenameIcon;

            return dialog;
        }
        public static NotesInputDialog GetNotesDialog(string input) {
            return new NotesInputDialog(input);
        }
        public static SelectDirectoryDialog GetMoveDialog(FileDirectory directory, Item discardItem) {
            return new SelectDirectoryDialog(directory, discardItem);
        }

        public static ConfirmationDialog ShowSaveDialog(){
            ConfirmationDialog dialog = new ConfirmationDialog(ConfirmationDialogType.YesNoCancel);

            dialog.Text = "Save";
            dialog.Message = "There are some changes. Do you want to save them?";
            dialog.Image = Properties.Resources._64pxSave;
            dialog.Sound = SystemSounds.Asterisk;
            dialog.Icon = Properties.Resources._64pxSaveIcon;
            dialog.YesButtonText = "Save";
            dialog.NoButtonText = "Don't Save";

            dialog.ShowDialog();

            return dialog;
        }

        public static PasswordInputDialog ShowNewPasswordDialog(string password) {
            PasswordInputDialog dialog = new PasswordInputDialog(password);
            dialog.ShowDialog();

            return dialog;
        }

        public static TextInputDialog ShowRenameDialog(string input, ItemNameValidator validator) {
            TextInputDialog dialog = new TextInputDialog(input);

            dialog.Text = "Rename";
            dialog.Message = "Rename this item";
            dialog.Image = Properties.Resources._64pxRename;
            dialog.Validator = validator.ValidateName;
            dialog.Icon = Properties.Resources._64pxRenameIcon;

            dialog.ShowDialog();

            return dialog;
        }
        public static ConfirmationDialog ShowDeleteDialog() {
            ConfirmationDialog dialog = new ConfirmationDialog(ConfirmationDialogType.YesCancel);

            dialog.Text = "Delete";
            dialog.Message = "Are you sure you want to delete this item?";
            dialog.Image = Properties.Resources._64pxTrash;
            dialog.Sound = SystemSounds.Hand;
            dialog.Icon = Properties.Resources._64pxTrashIcon;
            dialog.YesButtonText = "Delete";

            dialog.ShowDialog();

            return dialog;
        }
        public static ConfirmationDialog ShowRemoveDialog() {
            ConfirmationDialog dialog = new ConfirmationDialog(ConfirmationDialogType.YesCancel);

            dialog.Text = "Remove";
            dialog.Message = "Are you sure you want to remove this item?";
            dialog.Image = Properties.Resources._64pxTrash;
            dialog.Sound = SystemSounds.Hand;
            dialog.Icon = Properties.Resources._64pxTrashIcon;
            dialog.YesButtonText = "Remove";

            dialog.ShowDialog();

            return dialog;
        }

        public static KeyInputDialog ShowCurrentKeyDialog(){
            KeyInputDialog dialog = new KeyInputDialog();
            dialog.Text = "Current key";
            dialog.Message = "Enter the current key";

            dialog.ShowDialog();

            return dialog;
        }
        public static KeyInputDialog ShowNewKeyInputDialog() {
            KeyInputDialog dialog = new KeyInputDialog();
            dialog.Text = "New key";
            dialog.Message = "Enter the new key";

            dialog.ShowDialog();

            return dialog;
        }
        public static ConfirmationDialog ShowChangeKeyDialog() {
            ConfirmationDialog dialog = new ConfirmationDialog(ConfirmationDialogType.YesCancel);

            dialog.Text = "Change key";
            dialog.Message = "Are you still sure you want to change the key?";
            dialog.Image = Properties.Resources._64pxKey;
            dialog.Sound = SystemSounds.Asterisk;
            dialog.Icon = Properties.Resources._64pxKeyIcon;
            dialog.YesButtonText = "Change";

            dialog.ShowDialog();

            return dialog;
        }

        public static TextInputDialog ShowDateInputDialog(DateTime time, string format, string title, string message) {
            TextInputDialog dialog = new TextInputDialog(time == new DateTime(0) ? "" : time.ToString());

            dialog.Text = title;
            dialog.Message = $"{message} | Format: {format}";
            dialog.Icon = Properties.Resources._64pxCalendarIcon;
            dialog.Image = Properties.Resources._64pxCalendar;

            dialog.ShowDialog();

            return dialog;
        }
        public static ConfirmationDialog ShowDateTimeSaveDialog(DateTime time, string format = "") {
            ConfirmationDialog dialog = new ConfirmationDialog(ConfirmationDialogType.YesNo);

            dialog.Text = "Date";
            dialog.Message = $"Is this the corrent date? {time.ToString(format, CultureInfo.InvariantCulture)}";
            dialog.Image = Properties.Resources._64pxCalendar;
            dialog.Sound = SystemSounds.Asterisk;
            dialog.Icon = Properties.Resources._64pxCalendarIcon;

            dialog.ShowDialog();

            return dialog;
        }
        public static bool ShowDateInputDialog(string title, string message, ref DateTime time) {
            string format = "dd.MM.yyyy HH:mm:ss";

            var dialog = ShowDateInputDialog(time, format, title, message);
            if (!dialog.NameValidated) return false;

            DateTime newTime;
            if (!DateTime.TryParseExact(dialog.InputText, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out newTime)) {
                ShowShortErrorDialog("Incorrent time format.");
                return false;
            }

            var confirmation = ShowDateTimeSaveDialog(newTime, "MMM dd, yyyy HH:mm:ss");
            if (confirmation.Confirmation != ConfirmationType.Yes) return false;

            if (time != new DateTime(0)) {
                if (newTime.TrimMilliseconds() == time.TrimMilliseconds()) {
                    ShowShortErrorDialog("The edit date is the same.");
                    return false;
                }
            }

            time = newTime;
            return true;
        }

        public static void ShowPasswordEditHistoryDialog(PasswordFile file) {
            new PasswordHistoryDialog(file).ShowDialog();
        }

        public static void ShowShortErrorDialog(string input) {
            MessageDialog dialog = new MessageDialog(input);

            dialog.Text = "Error";
            dialog.Sound = SystemSounds.Hand;
            dialog.Image = SystemIcons.Error.ToBitmap();
            dialog.Icon = SystemIcons.Error;
            dialog.TextBorderStyle = System.Windows.Forms.BorderStyle.None;
            dialog.Sizeable = false;

            dialog.ShowDialog();
        }
        public static void ShowErrorDialog(Exception e){
            MessageDialog dialog = new MessageDialog(e.ToString());

            dialog.Text = $"Error | {e.Message}";
            dialog.Sound = SystemSounds.Hand;
            dialog.Image = SystemIcons.Error.ToBitmap();
            dialog.Icon = SystemIcons.Error;

            dialog.ShowDialog();
        }
    }
}
