using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class Ucenici: Korisnici
    {
        public string ImeRoditelja { get; set; }
        public int GodinaUpisa { get; set; }
        public int SmjerId { get; set; }
        public string NazivOsnovneSkole { get; set; }
        public Nullable<double> ProsjekOcjenaOsnovnaSkola { get; set; }
    }
}
