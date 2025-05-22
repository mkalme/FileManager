using System;
using System.Security.Cryptography;
using AesEncryption;

namespace GUI {
    public class KeyGenerator {
        public static Key GenerateKey() {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider()) {
                byte[] key = new byte[32];

                rng.GetBytes(key);

                return new Key(key);
            }
        }
    }
}
