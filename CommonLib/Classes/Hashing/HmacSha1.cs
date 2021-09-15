using CommonLib.Classes.Interfaces;
using System;
using System.Security.Cryptography;
using System.Text;

namespace CommonLib.Classes.Hashing
{
    internal class HmacSha1 : IHmac
    {
        HMACSHA1 hMACSHA1 = new HMACSHA1();
        public string Hash(string input, string password)
        {
            hMACSHA1.Key = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(hMACSHA1.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public byte[] Hash(byte[] input, byte[] password)
        {
            hMACSHA1.Key = password;
            return hMACSHA1.ComputeHash(input);
        }
    }
}
