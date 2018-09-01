using Newtonsoft.Json;
using SrednjeSkole.Models;
using SrednjeSkole.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace SrednjeSkole.Views.Materijali
{

    //public class Predmeti
    //{
    //    public int PredmetId { get; set; }
    //    public string Naziv { get; set; }
    //    public string Oznaka { get; set; }
    //    public int Razred { get; set; }
    //}

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaterijaliPage : ContentPage
    {
        private WebAPIHelper materijaliService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), "api/Materijali");
        private WebAPIHelper predmetiService = new WebAPIHelper(Xamarin.Forms.Application.Current.Resources["APIAddress"].ToString(), "api/Predmeti");
        private List<Predmeti> predmeti = new List<Predmeti>();
        private ObservableCollection<Materijali_Result> materijali = new ObservableCollection<Materijali_Result>();
        private int predmetIndex;
        

        public MaterijaliPage()
		{
			InitializeComponent ();

            BindRazredi();
            razrediPicker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);
            predmetiPicker.On<iOS>().SetUpdateMode(UpdateMode.WhenFinished);
            razrediPicker.SelectedIndex = 0; //selectedIndexChange poziva bindPredmeti
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
            int razred = Convert.ToInt32(razrediPicker.SelectedItem);

            HttpResponseMessage response = predmetiService.GetActionResponse("ByRazred", razred.ToString());
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = response.Content.ReadAsStringAsync();
                predmeti = JsonConvert.DeserializeObject<List<Predmeti>>(jsonResult.Result);
                predmetIndex = predmetiPicker.SelectedIndex =  0; // posto se mijenja razred
                predmetiPicker.ItemsSource = predmeti;
                //predmetiPicker.ItemDisplayBinding = new Binding("Naziv"); //preklopljen je opreator ToString u predmetima pa ne treba ovo
            }
        }
        private void BindMaterijali()
        {
            int predmetId = 0;
            if (predmetIndex != -1)
            {
                predmetId = predmeti[predmetIndex].PredmetId;
                HttpResponseMessage response = materijaliService.GetActionResponse("ByPredmetId", predmetId.ToString());

                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = response.Content.ReadAsStringAsync();
                    materijali = JsonConvert.DeserializeObject<ObservableCollection<Materijali_Result>>(jsonResult.Result);                    
                    materijaliList.ItemsSource = materijali;                    
                }
                else
                {
                    DisplayAlert("Info", "Nema materijala za odabrani razred", "OK");
                }
            }           
        }        

        private void BindPreporuka()
        {

        }
        private void razrediPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            predmetIndex = predmetiPicker.SelectedIndex = 0;
            predmetiPicker.Unfocus();
            BindPredmeti();          
        }

        private void predmetiPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            predmetIndex = predmetiPicker.SelectedIndex;
            BindMaterijali();
        }               

        private void materijaliList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var materijalItem = e.Item as Materijali_Result;
            this.Navigation.PushAsync(new OcijeniMaterijal(materijalItem));
        }

        private void preuzmi_Clicked(object sender, EventArgs e)
        {
            var preuzmiIcon = sender as MenuItem;
            var materijalItem = preuzmiIcon.CommandParameter as Materijali_Result;

            DisplayAlert("Call", materijalItem.Url, "OK");
        }
        private void addOcjena_Clicked(object sender, EventArgs e)
        {
            var preuzmiIcon = sender as MenuItem;
            var materijalItem = preuzmiIcon.CommandParameter as Materijali_Result;
            this.Navigation.PushAsync(new OcijeniMaterijal(materijalItem));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}