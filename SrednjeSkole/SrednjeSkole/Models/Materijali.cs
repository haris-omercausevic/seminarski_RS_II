using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class Materijali
    {
        public int MaterijalId { get; set; }
        public string Naziv { get; set; }
        public string BlobName { get; set; }
        public string Url { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int PredmetId { get; set; }
        public int NastavnikId { get; set; }

        public virtual Nastavnici Nastavnici { get; set; }
        public virtual Predmeti Predmeti { get; set; }
    }
}
