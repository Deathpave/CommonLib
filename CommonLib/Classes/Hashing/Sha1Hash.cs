using CommonLib.Classes.Interfaces;
using System;
using System.Security.Cryptography;
using System.Text;

namespace CommonLib.Classes.Hashing
{
    internal class Sha1Hash : IHash
    {
        SHA1 sHA1 = SHA1.Create();
        public string Hash(string input)
        {
            return Convert.ToBase64String(sHA1.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public byte[] Hash(byte[] input)
        {
            return sHA1.ComputeHash(input);
        }
    }
}
