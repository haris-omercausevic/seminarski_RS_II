using SrednjeSkole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrednjeSkole
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OcijeniMaterijal : ContentPage
	{
		public OcijeniMaterijal (Materijali_Result materijal)
		{
			InitializeComponent ();
            nazivMaterijalaLabel.Text = materijal.Naziv;
            datumLabel.Text = materijal.Datum;
            nastavnikLabel.Text = materijal.nastavnik;

		}
	}
}