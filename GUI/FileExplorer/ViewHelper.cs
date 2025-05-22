using System;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using FileManager;
using AesEncryption;

namespace GUI {
    public static class ViewHelper {
        public static Image GetIcon(this Item item) {
            Type type = item.GetType();

            if (type == typeof(FileDirectory)) {
                return Properties.Resources._22pxFolder;
            } else if (type == typeof(PasswordFile)) {
                return Properties.Resources._22pxPassword;
            }

            return Properties.Resources._22pxDocument;
        }
        public static void SetToClipBoard(this string value) {
            if (string.IsNullOrEmpty(value)) Clipboard.SetText(" ");
            else Clipboard.SetText(value);
        }

        public static string Parse(this DateTime time) {
            return time.ToString("MMM dd, yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }
        public static string ParseTimeSpan(this TimeSpan time){
            long seconds = (long)time.TotalSeconds;

            if (seconds < 60) {
                return $"{time.Seconds} {(time.Seconds == 1 ? "second" : "seconds")} ago";
            }
            if (seconds < 3600) {
                return $"{time.Minutes} {(time.Minutes == 1 ? "minute" : "minutes")} ago";
            }
            if (seconds < 86400) {
                return $"{time.Hours} {(time.Hours == 1 ? "hour" : "hours")} ago";
            }
            if (seconds < 604800) {
                return $"{time.Days} {(time.Days == 1 ? "day" : "days")} ago";
            }
            if (seconds < 2592000) {
                long weeks = seconds / 604800;
                return $"{weeks} {(weeks == 1 ? "week" : "weeks")} ago";
            }
            if (seconds < 31536000) {
                long months = seconds / 2592000;
                return $"{months} {(months == 1 ? "month" : "months")} ago";
            }

            long years = seconds / 31536000;
            return $"{years} {(years == 1 ? "year" : "years")} ago";
        }

        public static bool ArrayEquals<T>(this T[] array1, T[] array2) {
            if (array1.Length != array2.Length) return false;

            for (int i = 0; i < array1.Length; i++) {
                if (!array1[i].Equals(array2[i])) return false;
            }

            return true;
        }
        public static bool Compare(this Key key1, Key key2) {
            return key1.GetKey().ArrayEquals(key2.GetKey());
        }

        public static DateTime TrimMilliseconds(this DateTime dt){
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0, dt.Kind);
        }
        public static string ParseVersion(this Version version) {
            return $"{version.Major}.{version.Minor}.{version.Build}";
        }
    }
}
