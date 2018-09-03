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

namespace SrednjeSkole.Views.Ocjene
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OcjeneGenericPage : ContentPage
	{
        private WebAPIHelper uceniciOcjeneService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), Global.UceniciOcjeneRoute);
        private List<UceniciOcjene_Result> ocjene;
        private string _razredId;
        public OcjeneGenericPage (string razredId, string title)
		{
			InitializeComponent ();
            this.Title = title;
            _razredId = razredId;
		}

        protected override void OnAppearing()
        {
            HttpResponseMessage response = uceniciOcjeneService.GetActionResponse("ByUceniciRazredi", Global.prijavljeniKorisnik.KorisnikId + "/" + _razredId);

            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                ocjene = JsonConvert.DeserializeObject<List<UceniciOcjene_Result>>(jsonResult.Result);
                ocjeneList.ItemsSource = ocjene;
                ukupanProsjek.Text = "Ukupan prosjek: " + ocjene.Average(x => x.ProsjecnaOcjena).ToString();
            }
            else
            {
                DisplayAlert("Error", "Error code: " + response.StatusCode + " Message: " + response.ReasonPhrase, "OK");
            }

            base.OnAppearing();
        }

        private void ocjeneList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}