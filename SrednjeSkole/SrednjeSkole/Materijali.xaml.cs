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
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SrednjeSkole
{
 
    //public class Predmeti
    //{
    //    public int PredmetId { get; set; }
    //    public string Naziv { get; set; }
    //    public string Oznaka { get; set; }
    //    public int Razred { get; set; }
    //}

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Materijali : ContentPage
	{
        private WebAPIHelper materijaliService = new WebAPIHelper("http://10.15.15.44", "api/Materijali");
        private WebAPIHelper predmetiService = new WebAPIHelper("http://10.15.15.44", "api/Predmeti");
        private List<Predmeti> predmeti = new List<Predmeti>();
        private int razred;
        private int predmetIndex;

        public Materijali ()
		{
			InitializeComponent ();
            BindRazredi();
            razrediPicker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);
            predmetiPicker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);
            razrediPicker.SelectedIndex = 0; //selectedIndex change poziva bindPredmeti
            predmetiPicker.SelectedIndex = 0; // samo za prvo ucitavanje, selectedIndexChange poziva BindMaterijali()
        }

        private void BindRazredi()
        {
            razrediPicker.Items.Add("1");
            razrediPicker.Items.Add("2");
            razrediPicker.Items.Add("3");
            razrediPicker.Items.Add("4");
        }                           
        private void BindPredmeti()
        {
            razred = Convert.ToInt32(razrediPicker.SelectedItem);

            HttpResponseMessage response = predmetiService.GetActionResponse("ByRazred", razred.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                predmeti = JsonConvert.DeserializeObject<List<Predmeti>>(jsonResult.Result);
                predmetIndex = predmetiPicker.SelectedIndex =  0; // posto se mijenja razred
                predmetiPicker.ItemsSource = predmeti;
            }
        }
        private void BindMaterijali()
        {
            razred = Convert.ToInt32(razrediPicker.SelectedItem);
            int predmetId = 0;
            if (predmetIndex != -1)
            {
                predmetId = predmeti[predmetIndex].PredmetId;
                HttpResponseMessage response = materijaliService.GetActionResponse("ByPredmetId", predmetId.ToString());

                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = response.Content.ReadAsStringAsync();
                    List<Models.Materijali> m = JsonConvert.DeserializeObject<List<Models.Materijali>>(jsonResult.Result);
                }
                else
                {
                    DisplayAlert("Info", "Nema materijala za odabrani razred", "OK");
                }
            }
            else
            {
                DisplayAlert("Info", "Nema predmeta BUG", "OK");
            }
        }        

        private void razrediPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            predmetIndex = predmetiPicker.SelectedIndex = 0;
            predmetiPicker.Unfocus();
            BindPredmeti();          
        }

        private void predmetiPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(predmetiPicker.SelectedIndex == -1)
                predmetIndex = predmetiPicker.SelectedIndex = 0;
            else
                predmetIndex = predmetiPicker.SelectedIndex;

            BindMaterijali();
        }
    }
}