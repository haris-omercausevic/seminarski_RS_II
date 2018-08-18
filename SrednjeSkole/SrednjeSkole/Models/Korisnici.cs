using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class Korisnici
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public bool Aktivan { get; set; }
        public string Spol { get; set; }
        public Nullable<System.DateTime> DatumRodjenja { get; set; }
        public string MjestoRodjenja { get; set; }
        public string JMBG { get; set; }
        public string Prebivaliste { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public string Opstina { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public List<Uloge> uloge{ get; set; }
    }
}
