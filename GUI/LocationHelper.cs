using System;
using System.Reflection;
using System.IO;

namespace GUI {
    public class LocationHelper {
        public static readonly string DirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}
