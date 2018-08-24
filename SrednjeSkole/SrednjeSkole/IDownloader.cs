using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole
{
    public interface IDownloader
    {
        void DownloadFile(string url, string fileName);
        event EventHandler<DownloadEventArgs> OnFileDownloaded;
    }

    public class DownloadEventArgs : EventArgs
    {
        public bool FileSaved = false;
        public DownloadEventArgs(bool fileSaved)
        {
            FileSaved = fileSaved;
        }
    }
}
