using Newtonsoft.Json;
using Plugin.DownloadManager;
using Plugin.DownloadManager.Abstractions;
using SrednjeSkole.Models;
using SrednjeSkole.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrednjeSkole.Views.Materijali
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OcijeniMaterijal : ContentPage
    {
        private WebAPIHelper materijaliOcjeneService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), "api/MaterijaliOcjene");
        
        private IDownloadFile _downloadFile;
        private bool _isDownloading = false, _downloadigFlag;
        IDownloader downloader = DependencyService.Get<IDownloader>();

        private Materijali_Result _materijal;

        public OcijeniMaterijal(Materijali_Result materijal)
        {
            InitializeComponent();
            downloader.OnFileDownloaded += OnFileDownloaded;
            _materijal = materijal;

            //CrossDownloadManager.Current.CollectionChanged += (sender, e) =>
            //  System.Diagnostics.Debug.WriteLine(
            //      "[DownloadManager] " + e.Action +
            //      " -> New items: " + (e.NewItems?.Count ?? 0) +
            //      " at " + e.NewStartingIndex +
            //      " || Old items: " + (e.OldItems?.Count ?? 0) +
            //      " at " + e.OldStartingIndex
            //  );
            nazivMaterijalaLabel.Text = materijal.Naziv;
            predmetLabel.Text = materijal.Predmet;
            razredLabel.Text = " - " +materijal.Razred.ToString() + " razred";
            datumLabel.Text += "Datum objave: " + materijal.Datum;
            nastavnikLabel.Text = "Objavio: " + materijal.nastavnik;
            ratingLabel.Text = "Rating: " + materijal.Rating.ToString() + "/5.00";
            brojOcjena.Text = "Broj ocjena: " + materijal.BrojOcjena.ToString();
            BindIsOcijenjeno();
        }

        private void HideOcijeniMaterijal()
        {
            ocijeniMaterijalLabel.IsVisible = false;
            ocijeniBtnStackLayout.IsVisible = false;
            zvijezdeStack.IsVisible = false;
            vecOcijenjenLabel.IsVisible = true;
        }
       
        private void BindIsOcijenjeno()
        {
            HttpResponseMessage response = materijaliOcjeneService.GetActionResponse("IsOcijenjeno", _materijal.MaterijalId.ToString() + "/" + Global.prijavljeniKorisnik.KorisnikId.ToString());
            if (response.IsSuccessStatusCode)
            {
                var ocijenjenoVec = Convert.ToString(response.Content.ReadAsStringAsync().Result);
                if (ocijenjenoVec == "true")
                {
                    HideOcijeniMaterijal();
                }
                else
                {
                    ocijeniMaterijalLabel.IsVisible = true;
                    ocijeniBtnStackLayout.IsVisible = true;
                    zvijezdeStack.IsVisible = true;
                    vecOcijenjenLabel.IsVisible = false;
                }
                //var ocijenenoResult = JsonConvert.DeserializeObject<bool>(jsonResult.Result);
            }
        }

        private int GetOcjena()
        {
            if (ratingText.Text == "Loše!")
                return 1;            
            if (ratingText.Text == "Nako!")
                return 2; 
            if (ratingText.Text == "Može proć!")
                return 3;
            if (ratingText.Text == "Dobar!")
                return 4;
            if (ratingText.Text == "Odličan!")
                return 5;

            return 0;
        }
      
        private void ocijeniButton_Clicked(object sender, EventArgs e)
        {
            int ocjena = GetOcjena();            
            if(ocjena != 0)
            {
                MaterijaliOcjene mo = new MaterijaliOcjene()
                {
                    Ocjena = ocjena,
                    UcenikId = Global.prijavljeniKorisnik.KorisnikId,
                    MaterijalId = _materijal.MaterijalId
                };
                HttpResponseMessage response = materijaliOcjeneService.PostResponse(mo);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Ocjena uspješno pohranjena", "", "OK");
                    ocijeniBtnStackLayout.IsEnabled = false;
                    HideOcijeniMaterijal();
                    //predmetiPicker.ItemDisplayBinding = new Binding("Naziv"); //preklopljen je opreator ToString u predmetima pa ne treba ovo
                }
            }
            else
            {
                DisplayAlert("Ocjena ne može biti 0!", "", "OK");
            }

        }

       

        #region download
        private void OnFileDownloaded(object sender, DownloadEventArgs e)
        {
            if (e.FileSaved)
            {
                DisplayAlert("XF Downloader", "File Saved Successfully", "Close");
            }
            else
            {
                DisplayAlert("XF Downloader", "Error while saving the file", "Close");
            }
        }
        private void downloadImage_Tapped(object sender, EventArgs e)
        {
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    DownloadMaterijal(_materijal.Url, _materijal.Naziv);break;
                case Device.iOS:
                        DownloadMaterijal(_materijal.Url, _materijal.Naziv); break;
                case Device.UWP:
                    downloader.DownloadFile(_materijal.Url, _materijal.Naziv);break;
                default:
                    DownloadMaterijal(_materijal.Url, _materijal.Naziv); break;
            }
            //downloader.DownloadFile(_materijal.Url, _materijal.Naziv);
        }
        public async void DownloadMaterijal(string url, string naziv)
        {
            try
            {
                    var downloadManager = CrossDownloadManager.Current;
                    _downloadFile = downloadManager.CreateDownloadFile(url);
                    Global.imeFajla = naziv;
                    downloadManager.Start(_downloadFile, true);

                    while (_isDownloading)
                        _isDownloading = IsDownloading(_downloadFile);

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
        #endregion

    }
}