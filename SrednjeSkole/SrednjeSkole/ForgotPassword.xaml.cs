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
	public partial class ForgotPassword : ContentPage
	{
        private WebAPIHelper korisniciService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), Global.KorisniciRoute);
        private WebAPIHelper autentifikacijaService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), Global.AutentifikacijaRoute);
       
        public ForgotPassword (string korisnickoIme = "")
		{
			InitializeComponent ();
            korisnickoImeInput.Text = korisnickoIme;
		}

        private void resetBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = autentifikacijaService.GetActionResponse("ResetPassword", korisnickoImeInput.Text);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Info", "Poslana Vam je nova lozinka na Email", "OK");
                    Navigation.PopAsync();
                }
                else if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    DisplayAlert("Greska", "Korisnik nije pronadjen" , "OK");
                }
                else
                {
                    DisplayAlert("Greska", " Error code: " + response.StatusCode + "Message: " + response.ReasonPhrase, "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Greska!", ex.Message, "OK");
            }

        }       
    }
}