using SrednjeSkole.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrednjeSkole.Views.Ocjene
{

   

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OcjenePage : TabbedPage
	{
        private List<string> razredi = Global.prijavljeniKorisnik.razredi;
        public List<String> razrediTitles = new List<String>() {"I","II","III","IV"};
        public OcjenePage ()
		{
			InitializeComponent ();
           
		}

        protected override void OnAppearing()
        {
            for (int i = 0; i < razredi?.Count; i++)
            {
                this.Children.Add(new OcjeneGenericPage(razredi[i], razrediTitles[i]));

                //if (i == 0)
                //{
                //    this.Children.Add(new OcjenePrviPage(razredi[i]));
                //}
                //else if (i == 1)
                //{
                //    this.Children.Add(new OcjeneDrugiPage(razredi[i]));
                //}
                //else if (i == 2)
                //{
                //    this.Children.Add(new OcjeneTreciPage(razredi[i]));
                //}
                //else if (i == 3)
                //{
                //    this.Children.Add(new OcjeneCetvrtiPage(razredi[i]));
                //}
            }

            base.OnAppearing();
        }

    }
}