using SrednjeSkole.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SrednjeSkole
{
    public partial class MainPage : ContentPage
    {
        private WebAPIHelper autentifikacijaService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), "api/Autentifikacija");

        public MainPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void obavijestiGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Obavijesti.ObavijestiPage());
        }
        private void materijaliGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Materijali.MaterijaliPage());
        }
        private void ocjeneGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Ocjene.OcjenePage());
        }
        private void userProfileGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.Profil.ProfilPage());

        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            HttpResponseMessage response = autentifikacijaService.GetActionResponse("logout", Global.AuthToken);
            Global.AuthToken = "";
            Navigation.PopToRootAsync();
            Navigation.PushAsync(new SrednjeSkole.Login());
        }
    }
}
