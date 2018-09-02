using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class Obavijesti
    {
        public int ObavijestId { get; set; }
        public string Naslov { get; set; }
        public string Tekst { get; set; }
        public string Datum { get; set; }
        public int KorisnikId { get; set; }
        public string Objavio { get; set; }
    }
}
