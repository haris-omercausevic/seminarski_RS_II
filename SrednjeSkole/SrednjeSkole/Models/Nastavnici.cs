using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class Nastavnici: Korisnici
    {
        public string Zvanje { get; set; }
        public System.DateTime DatumIzboraUZvanje { get; set; }
        public string NaucnaOblast { get; set; }
        public int GodinaZaposlenja { get; set; }
    }
}
