using SrednjeSkole.ViewModels;
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
		public OcijeniMaterijal (MaterijaliVM materijal)
		{
			InitializeComponent ();
            nazivMaterijalaLabel.Text = materijal.Naziv;
            datumLabel.Text = materijal.DateCreated.ToShortDateString();
            nastavnikLabel.Text = materijal.nastavnik;

		}
	}
}