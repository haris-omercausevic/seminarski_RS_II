using Newtonsoft.Json;
using SrednjeSkole.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SrednjeSkole
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            bool isLoggedIn = Xamarin.Forms.Application.Current.Resources.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(Xamarin.Forms.Application.Current.Resources["IsLoggedIn"]) : false;
            if (!isLoggedIn)
            {
                MainPage = new NavigationPage(new SrednjeSkole.Login());
            }
            else
            {
                if (Xamarin.Forms.Application.Current.Resources.ContainsKey("UserDetail"))
                {
                    Global.prijavljeniKorisnik = JsonConvert.DeserializeObject<Korisnici>(Xamarin.Forms.Application.Current.Resources["UserDetail"].ToString());
                    MainPage = new NavigationPage(new SrednjeSkole.MainPage());
                }

            }            
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
