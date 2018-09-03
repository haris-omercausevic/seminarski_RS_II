using Newtonsoft.Json;
using SrednjeSkole.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SrednjeSkole.Views.Obavijesti
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ObavijestiPage : ContentPage
	{
        private WebAPIHelper obavijestiService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), Global.ObavijestiRoute);
        private string _pretragaText;
        public ObavijestiPage ()
		{
			InitializeComponent ();
            BindList();

        }

        private void BindList(string pretragaInput = "")
        {
            try
            {
                HttpResponseMessage response = obavijestiService.GetActionResponse("Pretraga", pretragaInput);
                if (response.IsSuccessStatusCode)
                {
                    var jsonObject = response.Content.ReadAsStringAsync();
                    List<Models.Obavijesti> vrste = JsonConvert.DeserializeObject<List<Models.Obavijesti>>(jsonObject.Result);
                    obavijestiList.ItemsSource = vrste;
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Greška", ex.Message, "OK");
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            _pretragaText = e.NewTextValue;
            BindList(e.NewTextValue);
        }

        private void obavijestiList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var obavijestItem = e.Item as Models.Obavijesti;
            var ocijeniMaterijalPage = new PregledObavijestiPage(obavijestItem);
            ocijeniMaterijalPage.Disappearing += (s, arg) => BindList(_pretragaText);
            this.Navigation.PushAsync(ocijeniMaterijalPage);
        }
    }
}