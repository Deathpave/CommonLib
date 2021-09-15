using System;
using CommonLib;
using CommonLib.Classes.Managers;

namespace LibTester
{
    class Program
    {
        private static SecurityManager securityManager = new SecurityManager();
        static void Main(string[] args)
        {
            // encryption and decryption

            // input
            string a = "Kage";
            // pass
            string b = "mand";

            // encrypted strings
            var aa = securityManager.EncryptString(a, b);
            var aaa = securityManager.EncryptString(a, b, 100);

            Console.WriteLine(aa);
            Console.WriteLine(aaa);

            // prints decrypted strings
            Console.WriteLine(securityManager.DecryptString(aa, b));
            Console.WriteLine(securityManager.DecryptString(aaa, b, 100));

            Console.ReadLine();
            //
        }
    }
}
