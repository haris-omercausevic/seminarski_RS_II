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
        private WebAPIHelper korisniciService = new WebAPIHelper(Global.APIAddres, "api/Korisnici");
        private WebAPIHelper ulogeService = new WebAPIHelper(Global.APIAddres, "api/Uloge");

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
                        HttpResponseMessage response2 = ulogeService.GetActionResponse("GetByKorisnikId", k.Id.ToString());
                        if (response2.IsSuccessStatusCode)
                        {
                            var jsonResult2 = response.Content.ReadAsStringAsync();
                            var temp = JsonConvert.DeserializeObject<Uloge>(jsonResult2.Result);


                            if (k.LozinkaHash == UIHelper.GenerateHash(k.LozinkaSalt, lozinkaInput.Text))
                            {
                                bool ulogeValidne = false;
                                foreach (var item in k.Uloge)
                                {
                                    if (item.Naziv == "Ucenik")
                                        ulogeValidne = true;
                                }
                                if (ulogeValidne == true)
                                {
                                    Navigation.PushAsync(new Materijali());
                                    Global.prijavljeniKorisnik = k;
                                }
                                else
                                    DisplayAlert("Upozorenje!", "Nemate pravo pristupa ovom dijelu sistema!", "OK");
                            }
                        }
                    }
                    else
                    {
                        DisplayAlert("Upozorenje!", "Korisničko ime ili lozinka nisu validni!", "OK");
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