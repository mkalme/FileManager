using System;
using System.IO;
using FileManager;
using AesEncryption;
using FastStream;
using FastStream.Extensions;

namespace GUI {
    public class ApplicationInfo {
        public static readonly string ApplicationPath = $"{LocationHelper.DirectoryPath}\\Manager\\app.afm";

        public static ApplicationInfo Current;

        private Key _key { get; set; }
        public Key Key => _key;

        private DateTime _created { get; set; }
        public DateTime Created => _created;

        private KeyHistory _keyHistory { get; set; }
        public KeyHistory KeyHistory => _keyHistory;

        private ApplicationInfo() {
        }
        public ApplicationInfo(Key key) {
            _key = key;

            _created = DateTime.Now;
            _keyHistory = new KeyHistory();
        }

        //Deserialize
        public static ApplicationInfo LoadFromLocalFile(Key key) {
            if (!CreateApplicationFile()) {
                ApplicationInfo info = new ApplicationInfo(key);
                info._keyHistory.Add(DateTime.Now);

                info.SaveToLocalFile();

                return info;
            }

            FastBinaryReader reader = new FastBinaryReader(AES.Decrypt(File.ReadAllBytes(ApplicationPath), key));
            
            ApplicationInfo deserializedInfo = Deserialize(reader);
            deserializedInfo._key = key;

            return deserializedInfo;
        }
        private static ApplicationInfo Deserialize(FastBinaryReader reader) {
            ApplicationInfo info = new ApplicationInfo();

            info._created = reader.ReadDateTime();
            info._keyHistory = KeyHistory.Deserialize(reader);

            return info;
        }

        private static bool CreateApplicationFile(){
            string directory = Path.GetDirectoryName(ApplicationPath);

            bool existed = true;
            if (!Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
                existed = false;
            }

            if (!File.Exists(ApplicationPath)) existed = false;

            return existed;
        }

        //Serialize
        public void SaveToLocalFile(){
            using (MemoryStream stream = new MemoryStream())
            using (FastBinaryWriter writer = new FastBinaryWriter(stream)) {
                Serialize(writer);

                File.WriteAllBytes(ApplicationPath, AES.Encrypt(stream.ToArray(), _key));
            }
        }
        private void Serialize(FastBinaryWriter writer) {
            writer.Write(_created);
            _keyHistory.Serialize(writer);
        }

        //Methods
        public void ChangeKey(Key newKey) {
            _key = newKey;
            _keyHistory.Add(DateTime.Now);
        }
    }
}
