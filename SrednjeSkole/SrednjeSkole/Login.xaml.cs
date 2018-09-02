using Newtonsoft.Json;
using SrednjeSkole.Models;
using SrednjeSkole.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrednjeSkole
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private WebAPIHelper korisniciService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), "api/Korisnici");
        private WebAPIHelper ulogeService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), "api/Uloge");
        private WebAPIHelper autentifikacijaService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), "api/Autentifikacija");

        IHash hasher = DependencyService.Get<IHash>();
        public Login()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
        private void prijavaBtn_Clicked(object sender, EventArgs e)
        {
            activityBusy.IsEnabled = true;
            activityBusy.IsVisible = true;
            activityBusy.IsRunning = true;
            try
            {
                if (String.IsNullOrEmpty(korisnickoImeInput.Text) || String.IsNullOrEmpty(lozinkaInput.Text))
                {
                    DisplayAlert("Greška", "Korisničko ime ili lozinka nisu uneseni!", "OK");
                    activityBusy.IsEnabled = false;
                    activityBusy.IsVisible = false;
                    activityBusy.IsRunning = false;
                    return;
                }
                HttpResponseMessage response = korisniciService.GetActionResponse("ByUsername", korisnickoImeInput.Text);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = response.Content.ReadAsStringAsync();
                    Korisnici k = JsonConvert.DeserializeObject<Korisnici>(jsonResult.Result);
                    if (k != null)
                    {
                        HttpResponseMessage response2 = ulogeService.GetActionResponse("GetByKorisnikId", k.Id.ToString());
                        if (response2.IsSuccessStatusCode)
                        {
                            var jsonResult2 = response2.Content.ReadAsStringAsync();
                            List<Uloge> u = JsonConvert.DeserializeObject<List<Uloge>>(jsonResult2.Result);
                            k.Uloge = u;
                            if (k.Uloge.Exists(x => x.Naziv == "Ucenik" || x.Naziv == "SuperAdministrator"))
                            {
                                LoginVM user = new LoginVM()
                                {
                                    username = k.KorisnickoIme,
                                    password = lozinkaInput.Text
                                };
                                HttpResponseMessage response3 = autentifikacijaService.PostActionResponse("login", user);
                                if (response3 != null && response3.IsSuccessStatusCode)
                                {
                                    var jsonResult3 = response3?.Content.ReadAsStringAsync();
                                    UIKorisnik result = JsonConvert.DeserializeObject<UIKorisnik>(jsonResult3.Result);
                                    Global.prijavljeniKorisnik = result;
                                    Global.AuthToken = result.AuthToken;

                                    Application.Current.MainPage = new NavigationPage(new MainPage());

                                    //if (k.LozinkaHash == hasher.GenerateHash(k.LozinkaSalt, lozinkaInput.Text))
                                    //{
                                    //    activityBusy.IsVisible = false;
                                    //    activityBusy.IsRunning = false;
                                    //    activityBusy.IsEnabled = false;
                                    //    Navigation.PushAsync(new MainPage());
                                    //    Global.prijavljeniKorisnik = k;

                                    //    Xamarin.Forms.Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
                                    //    Xamarin.Forms.Application.Current.Properties["AuthToken"] = JsonConvert.SerializeObject(k);
                                    //}
                                }
                                else
                                {
                                    DisplayAlert("Upozorenje!", "Korisničko ime ili lozinka nisu validni!", "OK");
                                }
                            }
                            else
                            {
                                DisplayAlert("Upozorenje!", "Vaša uloga nije podržana!", "OK");
                            }
                        }
                        else
                        {
                            DisplayAlert("Greska", "Error code: " + response.StatusCode + "Message: " + response.ReasonPhrase, "OK");
                        }
                    }
                }
                else
                {
                    DisplayAlert("Greska", "Error code: " + response.StatusCode + "Message: " + response.ReasonPhrase, "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Greska!", ex.Message, "OK");
            }
            activityBusy.IsEnabled = false;
            activityBusy.IsVisible = false;
            activityBusy.IsRunning = false;
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassword());
        }
    }
}