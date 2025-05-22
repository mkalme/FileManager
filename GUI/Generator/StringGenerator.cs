using System;
using System.Security.Cryptography;
using System.Text;

namespace GUI {
    public class StringGenerator {
        static readonly string Valid = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";

        public static string GenerateString(int length) {
            StringBuilder res = new StringBuilder();

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0) {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(Valid[(int)(num % (uint)Valid.Length)]);
                }
            }

            return res.ToString();
        }
    }
}
