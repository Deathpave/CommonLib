using CommonLib.Classes.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Classes.Managers
{
    public class SecurityManager
    {
        private Encrypt _encrypt;

        public void Test()
        {
            // Creates a new instance of encryption classs
            _encrypt = new Encrypt();
            //
            // Do code here
            //
            // Disposes of data in encryption class
            _encrypt.Dispose();
            // Nulls instance of encryption class
            _encrypt = null;
        }
    }
}