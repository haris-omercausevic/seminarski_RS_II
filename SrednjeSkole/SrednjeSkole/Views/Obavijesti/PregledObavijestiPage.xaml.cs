using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrednjeSkole.Views.Obavijesti
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PregledObavijestiPage : ContentPage
	{
		public PregledObavijestiPage (Models.Obavijesti obavijest)
		{
			InitializeComponent ();
            naslovLabel.Text = obavijest.Naslov;
            datumLabel.Text = obavijest.Datum;
            objavioLabel.Text = obavijest.Objavio;
            tekstLabel.Text = obavijest.Tekst;
		}
	}
}