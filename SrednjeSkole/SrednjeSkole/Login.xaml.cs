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

        public Login()
        {
            InitializeComponent();
        }

        private void prijavaBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = korisniciService.GetActionResponse("ByUsername", korisnickoImeInput.Text);
                
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = response.Content.ReadAsStringAsync();
                    Korisnici k = JsonConvert.DeserializeObject<Korisnici>(jsonResult.Result);
                    if (k != null)
                    {
                            if (k.LozinkaHash == UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text))
                            {                              
                                    Navigation.PushAsync(new MainPage());
                                    Global.prijavljeniKorisnik = k;                               
                            }
                        else
                        {
                            DisplayAlert("Upozorenje!", "Korisničko ime ili lozinka nisu validni!", "OK");
                        }                    
                    }                    
                }
                else
                {
                    DisplayAlert("Greska" ,"Error code: " + response.StatusCode + "Message: " + response.ReasonPhrase, "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Greska!", ex.Message, "OK"); 
            }
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPassword());
        }
    }
}