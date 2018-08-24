using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Foundation;
using UIKit;

using System.IO;
using System.Net;
using System.ComponentModel;
using Xamarin.Forms;

[assembly: Dependency(typeof(SrednjeSkole.iOS.IosDownloader))]
namespace SrednjeSkole.iOS
{
    public class IosDownloader: IDownloader
    {
        public event EventHandler<DownloadEventArgs> OnFileDownloaded;

        public void DownloadFile(string url, string fileName)
        {
            string pathToNewFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), fileName);
            Directory.CreateDirectory(pathToNewFolder);

            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                string pathToNewFile = Path.Combine(pathToNewFolder, Path.GetFileName(url));
                webClient.DownloadFileAsync(new Uri(url), pathToNewFile);
            }
            catch (Exception ex)
            {
                if (OnFileDownloaded != null)
                    OnFileDownloaded.Invoke(this, new DownloadEventArgs(false));
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                if (OnFileDownloaded != null)
                    OnFileDownloaded.Invoke(this, new DownloadEventArgs(false));
            }
            else
            {
                if (OnFileDownloaded != null)
                    OnFileDownloaded.Invoke(this, new DownloadEventArgs(true));
            }
        }
    }
}