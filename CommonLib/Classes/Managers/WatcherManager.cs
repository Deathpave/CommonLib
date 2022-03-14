using CommonLib.Classes.Watchers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CommonLib.Classes.Managers
{
    public class WatcherManager
    {
        FileSystemWatcher watcher;
        FolderWatcher folderWatcher;

        public void StartWatcher(string folderPath, bool includeSubDirectories)
        {
            folderWatcher = new FolderWatcher();
            folderWatcher.GetData += HandleWatcher;
            watcher = folderWatcher.CreateWatcher(folderPath, includeSubDirectories);
            var x = watcher.WaitForChanged(WatcherChangeTypes.All);
        }

        private void HandleWatcher(object sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }
    }
}
