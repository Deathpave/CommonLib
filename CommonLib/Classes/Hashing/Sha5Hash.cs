using CommonLib.Classes.Interfaces;
using System;
using System.Security.Cryptography;
using System.Text;

namespace CommonLib.Classes.Hashing
{
    internal class Sha5Hash : IHash
    {
        SHA512 sHA512 = SHA512.Create();
        public string Hash(string input)
        {
            return Convert.ToBase64String(sHA512.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public byte[] Hash(byte[] input)
        {
            return sHA512.ComputeHash(input);
        }
    }
}
