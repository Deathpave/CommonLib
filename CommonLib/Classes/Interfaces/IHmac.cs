using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Classes.Interfaces
{
    internal interface IHmac
    {
        string Hash(string input, string password);
        byte[] Hash(byte[] input, byte[] password);
    }
}
