using Newtonsoft.Json;
using SrednjeSkole.Models;
using SrednjeSkole.Util;
using System;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SrednjeSkole
{
    public partial class App : Application
    {
        WebAPIHelper autentifikacijaService = new WebAPIHelper("http://10.15.15.44/", "api/Autentifikacija");
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(GetMainPage());
        }
             

        private Page GetMainPage()
        {
            if (!string.IsNullOrEmpty(Global.AuthToken))
                return LoginWithToken();

            return new Login();
        }

        private Page LoginWithToken()
        {
            HttpResponseMessage response = autentifikacijaService.PostActionResponse("loginwithtoken", Global.AuthToken);

            if (response != null && response.IsSuccessStatusCode)
            {
                var jsonObject = response?.Content.ReadAsStringAsync();
                UIKorisnik result = JsonConvert.DeserializeObject<UIKorisnik>(jsonObject.Result);

                Global.prijavljeniKorisnik = result;
                Global.AuthToken = result.AuthToken;

                return new MainPage();
            }
            else
                return new Login();
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
