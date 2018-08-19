using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.ViewModels
{
    public class MaterijaliVM
    {
        public int MaterijalId { get; set; }
        public string Naziv { get; set; }
        public string BlobName { get; set; }
        public string Url { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string nastavnik { get; set; }
        public string rating { get; set; }
        public int PredmetId { get; set; }
        public int NastavnikId { get; set; }

    }
}
