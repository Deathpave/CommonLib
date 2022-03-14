using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;
using CommonLib;
using CommonLib.Classes.Managers;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace LibTester
{
    class Program
    {
        static void Main(string[] args)
        {
            WatcherManager manager = new WatcherManager();
            manager.StartWatcher(@"C:\Watcher", true);
            while (true)
            {

            }
        }
    }
}