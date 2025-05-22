using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using FastStream;

namespace FileManager {
    static class ManagerHelper {
        //Item
        public static Item GetItem(this Type type, FastBinaryReader reader) {
            if (type == typeof(FileDirectory)) {
                return FileDirectory.Deserialize(reader);
            }else if (type == typeof(PasswordFile)) {
                return PasswordFile.Deserialize(reader);
            }else if (type == typeof(Document)) {
                return Document.Deserialize(reader);
            }

            return null;
        }

        //Type
        public static Type GetType(this byte id) {
            return ID.FirstOrDefault(x => x.Value == id).Key;
        }
        public static byte GetID(this Type type) {
            byte id;
            if (!ID.TryGetValue(type, out id)) {
                id = byte.MaxValue;
            }

            return id;
        }

        static readonly Dictionary<Type, byte> ID = new Dictionary<Type, byte>() {
            { typeof(FileDirectory), 0 },
            { typeof(PasswordFile), 1 },
            { typeof(Document), 2 },
        };
    }

    static class DateTimeExtensions {
        public static DateTime TrimMilliseconds(this DateTime dt) {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, 0, dt.Kind);
        }
    }

    static class FontHelper{
        public static bool FontEquals(this Font font1, Font font2) {
            if (font1.Name != font2.Name) return false;
            if (font1.Size != font2.Size) return false;
            if (font1.Style != font2.Style) return false;

            return true;
        }
    }
}
