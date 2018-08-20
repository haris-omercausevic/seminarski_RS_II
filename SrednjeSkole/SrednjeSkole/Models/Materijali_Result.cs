using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class Materijali_Result
    {
        public int MaterijalId { get; set; }
        public string Naziv { get; set; }
        public string Url { get; set; }
        public string BlobName { get; set; }
        public string Datum { get; set; }
        public int BrojOcjena { get; set; }
        public decimal Rating { get; set; }
        public int PredmetId { get; set; }
        public int NastavnikId { get; set; }
        public string nastavnik { get; set; }
    }
}
