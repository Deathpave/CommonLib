using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Classes.Encryption
{
    internal class Encrypt
    {
        // Rijndael class
        RijndaelManaged rijndael = new RijndaelManaged();
        public string EncryptString(string input, string password)
        {
            // Salt byte array
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            // Derived bytes to make key and vector
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, salt);

            // Key gets set
            rijndael.Key = rfc.GetBytes(32);

            // Vector gets set
            rijndael.IV = rfc.GetBytes(16);

            // Creates stream to "write" the data
            MemoryStream memoryStream = new MemoryStream();

            // Creates stream to "write" the data            
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);

            // Gets bytes of the input
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Converts the input bytes to encrypted bytes
            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
            cryptoStream.FlushFinalBlock();
            cryptoStream.Close();

            // Converts the encryted bytes back to string
            string result = Convert.ToBase64String(memoryStream.ToArray());
            return result;
        }

        public string EncryptString(string input, string password, int itterations)
        {
            // Salt byte array
            byte[] salt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            // Derived bytes to make key and vector
            Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(password, salt, itterations);

            // Key gets set
            rijndael.Key = rfc.GetBytes(32);

            // Vector gets set
            rijndael.IV = rfc.GetBytes(16);

            // Creates stream to "write" the data
            MemoryStream memoryStream = new MemoryStream();

            // Creates stream to "write" the data            
            CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);

            // Gets bytes of the input
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Converts the input bytes to encrypted bytes
            cryptoStream.Write(inputBytes, 0, inputBytes.Length);
            cryptoStream.FlushFinalBlock();
            cryptoStream.Close();

            // Converts the encryted bytes back to string
            string result = Convert.ToBase64String(memoryStream.ToArray());
            return result;
        }
    }
}
