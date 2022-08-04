using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace _2.KompresjaSzyfrowanie
{
    internal class Aes
    {
     /*   Aes aes = Aes.Create();
        CryptoStream cryptStream = new CryptoStream(
            fileStream, aes.CreateEncryptor(key, iv), CryptoStreamMode.Write);

        using (FileStream fileStream = new ("TestData.txt", FileMode.OpenOrCreate))
    {
        using (Aes aes = Aes.Create())
        {
            byte[] key =
            {
                0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
            };
    aes.Key = key;

            byte[] iv = aes.IV;
    fileStream.Write(iv, 0, iv.Length);

            using (CryptoStream cryptoStream = new (
                fileStream,
                aes.CreateEncryptor(),
                CryptoStreamMode.Write))
            {
                using (StreamWriter encryptWriter = new (cryptoStream))
                {
                    encryptWriter.WriteLine("Hello World!");
                }
            }
        }
    }*/
    }
}
