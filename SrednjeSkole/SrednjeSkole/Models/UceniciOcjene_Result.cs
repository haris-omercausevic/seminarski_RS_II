using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class UceniciOcjene_Result
    {
        public int Id { get; set; }
        public int UcenikId { get; set; }
        public int PredajeId { get; set; }
        public int Vrijednost { get; set; }
        public System.DateTime Datum { get; set; }
        public string TipOcjene { get; set; }
        public string Napomena { get; set; }
    }
}
