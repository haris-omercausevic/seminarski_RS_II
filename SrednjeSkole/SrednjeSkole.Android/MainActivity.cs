using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Plugin.DownloadManager;
using System.IO;
using Plugin.DownloadManager.Abstractions;
using System.Linq;

using Android.Util;

namespace SrednjeSkole.Droid
{
    [Activity(Label = "SrednjeSkole", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        #region MyCode
        void InitDownloadManager()
        {
            CrossDownloadManager.Current.PathNameForDownloadedFile = new System.Func<IDownloadFile, string>(file =>
            {
                //Android.Net.Uri.Parse(file.Url).Path.Split('/').Last();
                //string fileName = string.Format(AppResources.AnnouncementDocumentFileName, DateTime.Now.ToString(AppResources.DateFormat));
                return Path.Combine(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).AbsolutePath, Global.imeFajla);
            });
            //(CrossDownloadManager.Current as DownloadManagerImplementation).IsVisibleInDownloadsUi = true;
            //Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryDownloads).AbsolutePath
        }
        #endregion
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            //InitDownloadManager();

            base.OnCreate(savedInstanceState);

            // This MobileServiceClient has been configured to communicate with the Azure Mobile App and
            // Azure Gateway using the application url. You're all set to start working with your Mobile App!
            Microsoft.WindowsAzure.MobileServices.MobileServiceClient SrednjeSkoleAppClient = new Microsoft.WindowsAzure.MobileServices.MobileServiceClient(
            "https://srednjeskoleapp.azurewebsites.net");
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
    }
}