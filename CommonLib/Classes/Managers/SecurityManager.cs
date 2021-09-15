using CommonLib.Classes.Decryption;
using CommonLib.Classes.Encryption;
using CommonLib.Classes.Hashing;
using System;

namespace CommonLib.Classes.Managers
{
    public class SecurityManager : IDisposable
    {
        private Encrypt _encrypt;
        private Decrypt _decrypt;

        public SecurityManager()
        {
            _encrypt = new Encrypt();
            _decrypt = new Decrypt();
        }

        public string EncryptString(string input, string password)
        {
            return _encrypt.EncryptString(input, password);
        }

        public string EncryptString(string input, string password, int itterations)
        {
            return _encrypt.EncryptString(input, password, itterations);
        }

        public string DecryptString(string input, string password)
        {
            return _decrypt.DecryptString(input, password);
        }

        public string DecryptString(string input, string password, int itterations)
        {
            return _decrypt.DecryptString(input, password, itterations);
        }

        public string Hash(HashType type, string input)
        {
            switch (type)
            {
                case HashType.Md5Hash:
                    Md5Hash md5 = new Md5Hash();
                    return md5.Hash(input);
                case HashType.Sha1Hash:
                    Sha1Hash sha1 = new Sha1Hash();
                    return sha1.Hash(input);
                case HashType.Sha2Hash:
                    Sha2Hash sha2 = new Sha2Hash();
                    return sha2.Hash(input);
                case HashType.Sha3Hash:
                    Sha3Hash sha3 = new Sha3Hash();
                    return sha3.Hash(input);
                case HashType.Sha5Hash:
                    Sha5Hash sha5 = new Sha5Hash();
                    return sha5.Hash(input);
                default:
                    return "Cannot hash with this input";
            }
        }

        public string Hash(HashType type, string input, string password)
        {
            switch (type)
            {
                case HashType.HmacSha1:
                    HmacSha1 hmacSha1 = new HmacSha1();
                    return hmacSha1.Hash(input, password);
                case HashType.HmacSha2:
                    break;
                default:
                    return "Cannot hash with these inputs";
            }
            return "Something went wrong during hashing";
        }

        public byte[] Hash(HashType type, byte[] input)
        {
            switch (type)
            {
                case HashType.Md5Hash:
                    Md5Hash md5 = new Md5Hash();
                    return md5.Hash(input);
                case HashType.Sha1Hash:
                    Sha1Hash sha1 = new Sha1Hash();
                    return sha1.Hash(input);
                case HashType.Sha2Hash:
                    Sha2Hash sha2 = new Sha2Hash();
                    return sha2.Hash(input);
                case HashType.Sha3Hash:
                    Sha3Hash sha3 = new Sha3Hash();
                    return sha3.Hash(input);
                case HashType.Sha5Hash:
                    Sha5Hash sha5 = new Sha5Hash();
                    return sha5.Hash(input);
                default:
                    return null;
            }
        }

        public byte[] Hash(HashType type, byte[] input, byte[] password)
        {
            switch (type)
            {
                case HashType.HmacSha1:
                    HmacSha1 hmacSha1 = new HmacSha1();
                    return hmacSha1.Hash(input, password);
                case HashType.HmacSha2:
                    break;
                default:
                    return null;
            }
            return null;
        }

        public void Dispose()
        {
            _encrypt = null;
            _decrypt = null;
        }
    }
}