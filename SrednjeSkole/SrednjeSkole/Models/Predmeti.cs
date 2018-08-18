using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class Predmeti
    {
        public int PredmetId { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public int Razred { get; set; }

        public override string ToString()
        {
            return Oznaka + " - " + Naziv;
        }
    }
}
