using CommonLib.Classes.Interfaces;
using System;
using System.Security.Cryptography;
using System.Text;

namespace CommonLib.Classes.Hashing
{
    internal class Sha2Hash : IHash
    {
        SHA256 sHA256 = SHA256.Create();
        public string Hash(string input)
        {
            return Convert.ToBase64String(sHA256.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public byte[] Hash(byte[] input)
        {
            return sHA256.ComputeHash(input);
        }
    }
}
