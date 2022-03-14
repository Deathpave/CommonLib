using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Classes.Watchers
{
    internal class FolderWatcher
    {
        public PropertyChangedEventHandler GetData;
        public FileSystemWatcher CreateWatcher(string folderPath, bool includeSubDirectories)
        {
            // edit path, to userinput
            // creates a new system watcher
            var watcher = new FileSystemWatcher(folderPath);
            // sets filters for the watcher
            watcher.NotifyFilter = NotifyFilters.Attributes
                    | NotifyFilters.CreationTime
                    | NotifyFilters.DirectoryName
                    | NotifyFilters.FileName
                    | NotifyFilters.LastAccess
                    | NotifyFilters.LastWrite
                    | NotifyFilters.Security
                    | NotifyFilters.Size;
            // subscribes to events
            watcher.Changed += OnChanged;
            watcher.Created += OnCreated;
            watcher.Deleted += OnDeleted;
            watcher.Renamed += OnRenamed;
            watcher.Error += OnError;
            // allows the watcher to raise events
            watcher.EnableRaisingEvents = true;
            // if true include subdirectories
            if (includeSubDirectories)
            {
                watcher.IncludeSubdirectories = true;
            }
            watcher.Filter = "*";
            return watcher;
        }
        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Changed)
            {
                GetData?.Invoke("", null);
            }
            GetData?.Invoke($"Changed: {e.FullPath}", null);
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            GetData?.Invoke($"Created: {e.FullPath}", null);
        }

        private void OnDeleted(object sender, FileSystemEventArgs e)
        {
            GetData?.Invoke($"Deleted: {e.FullPath}", null);
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {
            GetData?.Invoke($"Renamed: {e.OldFullPath} to {e.FullPath}", null);
        }

        private void OnError(object sender, ErrorEventArgs e)
        {
            if (e != null)
            {
                GetData?.Invoke($"{e.GetException()}", null);
            }
            GetData?.Invoke("", null);
        }
    }
}
