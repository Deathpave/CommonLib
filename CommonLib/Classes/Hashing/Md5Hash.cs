using System;
using System.Security.Cryptography;
using System.Text;

namespace CommonLib.Classes.Hashing
{
    internal class Md5Hash
    {
        MD5 mD5 = MD5.Create();

        public byte[] Hash(byte[] input)
        {
            return mD5.ComputeHash(input);
        }

        public string Hash(string input)
        {
            return Convert.ToBase64String(mD5.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }
    }
}
