using System;
using System.IO;
using FileManager;
using AesEncryption;

namespace GUI {
    public static class ManagerInfo {
        public static readonly string ManagerPath = $"{LocationHelper.DirectoryPath}\\Manager\\manager.fmd";

        public static FileDirectory Current;

        public static FileDirectory LoadFromLocalFile(Key key) {
            if (!CreateRootFile()) {
                FileDirectory directory = new FileDirectory("Root");
                directory.Save(ManagerPath, key);

                return directory;
            }

            return FileDirectory.FromFile(ManagerPath, key);
        }
        private static bool CreateRootFile(){
            string directory = Path.GetDirectoryName(ManagerPath);

            bool existed = true;
            if (!Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
                existed = false;
            }

            if (!File.Exists(ManagerPath)) existed = false;

            return existed;
        }

        //Methods
        public static void Save() {
            Current.Save(ManagerPath, ApplicationInfo.Current.Key);
        }
    }
}
