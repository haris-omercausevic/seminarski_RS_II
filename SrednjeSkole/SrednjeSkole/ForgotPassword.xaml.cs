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
        private WebAPIHelper korisniciService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), "api/Korisnici");

        public ForgotPassword (string korisnickoIme = "")
		{
			InitializeComponent ();
            korisnickoImeInput.Text = korisnickoIme;
		}

        private void resetBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = korisniciService.GetActionResponse("ResetPassword", korisnickoImeInput.Text);
                if (response.IsSuccessStatusCode)
                {
                    DisplayAlert("Info", "Poslana Vam je nova lozinka na Email", "OK");
                    Navigation.PopAsync();
                }
                else
                {
                    DisplayAlert("Greska", "Korisnik nije pronadjen..." +
                        " Error code: " + response.StatusCode + "Message: " + response.ReasonPhrase, "OK");

                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Greska!", ex.Message, "OK");
            }

        }       
    }
}