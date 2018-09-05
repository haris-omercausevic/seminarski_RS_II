using Newtonsoft.Json;
using SrednjeSkole.Models;
using SrednjeSkole.Util;
using System;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Push;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SrednjeSkole
{
    public partial class App : Application
    {
        WebAPIHelper autentifikacijaService = new WebAPIHelper("http://10.10.10.50/", Global.AutentifikacijaRoute);
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
                Application.Current.SavePropertiesAsync();

                return new MainPage();
            }
            else
                return new Login();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=22888782-67d7-46b1-b94f-d442beb452f9;" +
                  "uwp=a861dddf-1315-45dc-b65e-c99d175bb48f;" +
                  "ios=cb9eed20-6755-40f3-a9c9-dfa2468b20e9", typeof(Push));
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
