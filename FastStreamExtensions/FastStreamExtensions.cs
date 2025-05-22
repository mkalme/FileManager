using System;
using FastStream;
using System.Drawing;

namespace FastStream.Extensions {
    public static class FastStreamExtensions {
        public static Font ReadFont(this FastBinaryReader reader){
            string fontFamily = reader.ReadString();
            float size = reader.ReadFloat();
            FontStyle style = (FontStyle)reader.ReadByte();

            return new Font(fontFamily, size, style);
        }
        public static void Write(this FastBinaryWriter writer, Font font){
            writer.Write(font.Name);
            writer.Write(font.Size);
            writer.Write((byte)font.Style);
        }

        public static Color ReadColor(this FastBinaryReader reader){
            byte r = reader.ReadByte();
            byte g = reader.ReadByte();
            byte b = reader.ReadByte();

            return Color.FromArgb(r, g, b);
        }
        public static void Write(this FastBinaryWriter writer, Color color){
            writer.Write(color.R);
            writer.Write(color.G);
            writer.Write(color.B);
        }

        public static DateTime ReadDateTime(this FastBinaryReader reader) {
            return new DateTime(reader.ReadInt64());
        }
        public static void Write(this FastBinaryWriter writer, DateTime dateTime) {
            writer.Write(dateTime.Ticks);
        }
    }
}
