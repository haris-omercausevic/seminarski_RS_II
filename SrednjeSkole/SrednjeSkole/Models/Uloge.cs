using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class Uloge
    {
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public bool SuperAdministrator { get; set; }
        public bool Administrator { get; set; }
        public bool Nastavnik { get; set; }
        public bool Ucenik { get; set; }
        public bool Roditelj { get; set; }
    }
}
