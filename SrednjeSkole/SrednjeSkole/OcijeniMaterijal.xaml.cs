using Plugin.DownloadManager;
using Plugin.DownloadManager.Abstractions;
using SrednjeSkole.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrednjeSkole
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OcijeniMaterijal : ContentPage
    {
        private IDownloadFile _downloadFile;
        private bool _isDownloading, _downloadigFlag = false;
        private Materijali_Result _materijal;

        public OcijeniMaterijal(Materijali_Result materijal)
        {
            InitializeComponent();

            _materijal = materijal;
            CrossDownloadManager.Current.CollectionChanged += (sender, e) =>
              System.Diagnostics.Debug.WriteLine(
                  "[DownloadManager] " + e.Action +
                  " -> New items: " + (e.NewItems?.Count ?? 0) +
                  " at " + e.NewStartingIndex +
                  " || Old items: " + (e.OldItems?.Count ?? 0) +
                  " at " + e.OldStartingIndex
              );
            nazivMaterijalaLabel.Text = materijal.Naziv;
            datumLabel.Text = materijal.Datum;
            nastavnikLabel.Text = materijal.nastavnik;
        }

        private void downloadImage_Tapped(object sender, EventArgs e)
        {
            DownloadMaterijal(_materijal.Url, _materijal.Naziv);

            //downloader.DownloadFile(item.Url, "SrednjeSkole_Downloads");
        }

        public void InitializeDownload(string url)
        {
            // File = CrossDownloadManager.Current.CreateDownloadFile(url);

            // If you need, you can add a dictionary of headers you need.
            //, new Dictionary<string, string> {
            //    { "Cookie", "LetMeDownload=1;" },
            //    { "Authorization", "Basic QWxhZGRpbjpvcGVuIHNlc2FtZQ==" }
            //}
        }
        public async void DownloadMaterijal(string url, string naziv)
        {
            await Task.Yield();
            try
            {
                await Task.Run(() =>
                {
                        var downloadManager = CrossDownloadManager.Current;
                        _downloadFile = downloadManager.CreateDownloadFile(url);
                        Global.imeFajla = naziv;
                        downloadManager.Start(_downloadFile, true);

                        while (_isDownloading)
                            _isDownloading = IsDownloading(_downloadFile);
                });

                if (!_isDownloading)
                {
                    await DisplayAlert("Info", "Materijal je uspješno preuzet", "OK");
                    _downloadigFlag = false;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("greska", ex.Message, "OK");
            }

        }

        public void AbortDownloading()
        {
            CrossDownloadManager.Current.Abort(_downloadFile);
        }

        public bool IsDownloading(IDownloadFile file)
        {
            if (file == null) return false;

            switch (file.Status)
            {
                case DownloadFileStatus.INITIALIZED:
                case DownloadFileStatus.PAUSED:
                case DownloadFileStatus.PENDING:
                case DownloadFileStatus.RUNNING:
                    return true;

                case DownloadFileStatus.COMPLETED:
                case DownloadFileStatus.CANCELED:
                case DownloadFileStatus.FAILED:
                    return false;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
}