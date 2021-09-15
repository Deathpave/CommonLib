using CommonLib.Classes.Decryption;
using CommonLib.Classes.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Dispose()
        {
            _encrypt = null;
            _decrypt = null;
        }
    }
}