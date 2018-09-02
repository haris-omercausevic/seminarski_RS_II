using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class UIKorisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] Slika { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }
        public string AuthToken { get; set; }
    }
}
