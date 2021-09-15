using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Classes.Interfaces
{
    internal interface IHash
    {
        string Hash(string input);
        byte[] Hash(byte[] input);
    }
}
