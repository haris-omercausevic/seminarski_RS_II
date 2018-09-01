﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SrednjeSkole
{
    public partial class MainPage : ContentPage
    {
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

    }
}
