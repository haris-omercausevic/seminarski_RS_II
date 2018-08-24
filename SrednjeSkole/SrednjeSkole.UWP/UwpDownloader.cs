using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
using Windows.Storage.Pickers;
using Xamarin.Forms;

[assembly: Dependency(typeof(SrednjeSkole.UWP.UwpDownloader))]

namespace SrednjeSkole.UWP
{
    public class UwpDownloader: IDownloader
    {
        public event EventHandler<DownloadEventArgs> OnFileDownloaded;
        DownloadOperation downloadOperation;
        Windows.Networking.BackgroundTransfer.BackgroundDownloader backgroundDownloader = new Windows.Networking.BackgroundTransfer.BackgroundDownloader();

        async public void DownloadFile(string url, string fileName)
        {
            string pathToNewFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), fileName);
            Directory.CreateDirectory(pathToNewFolder);
            FolderPicker folderPicker = new FolderPicker();
            folderPicker.SuggestedStartLocation = PickerLocationId.Downloads;
            folderPicker.ViewMode = PickerViewMode.Thumbnail;
            folderPicker.FileTypeFilter.Add("*");
            StorageFolder folder = await folderPicker.PickSingleFolderAsync();
            if (folder != null)
            {
                StorageFile file = await folder.CreateFileAsync(fileName, CreationCollisionOption.GenerateUniqueName);
                Uri durl = new Uri(url);
                downloadOperation = backgroundDownloader.CreateDownload(durl, file);
                try
                {
                    await downloadOperation.StartAsync();

                    //Uri source = new Uri(url);

                    //StorageFile destinationFile = await KnownFolders.PicturesLibrary.CreateFileAsync(
                    //    fileName, CreationCollisionOption.GenerateUniqueName);

                    //BackgroundDownloader downloader = new BackgroundDownloader();
                    //DownloadOperation download = downloader.CreateDownload(source, destinationFile);
                    //download.StartAsync();

                    // Attach progress and completion handlers.
                    //HandleDownloadAsync(download, true);
                }
                catch (Exception ex)
                {
                    if (OnFileDownloaded != null)
                        OnFileDownloaded.Invoke(this, new DownloadEventArgs(false));
                }
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
