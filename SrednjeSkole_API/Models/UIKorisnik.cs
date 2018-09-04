﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SrednjeSkole_API.Models
{
    public class UIKorisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public List<string> razredi { get; set; }//ID-ovi razreda
        public List<string> razrediBrojcano { get; set; } //razredi brojcano
        public byte[] Slika { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }
        public string AuthToken { get; set; }
    }
}