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
    public class WatcherManager : IDisposable
    {
        private FileSystemWatcher _watcher;
        private FolderWatcher _folderWatcher;
        public event PropertyChangedEventHandler PropertyChanged;

        public void StartWatcher(string folderPath, bool includeSubDirectories)
        {
            _folderWatcher = new FolderWatcher();
            _folderWatcher.GetData += HandleWatcher;
            _watcher = _folderWatcher.CreateWatcher(folderPath, includeSubDirectories);
            var x = _watcher.WaitForChanged(WatcherChangeTypes.All);
        }

        private void HandleWatcher(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(sender, null);
        }

        public void Dispose()
        {
            _folderWatcher.GetData -= HandleWatcher;
            _watcher = null;
            _folderWatcher = null;
        }
    }
}
