using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SrednjeSkole_API.Models
{
    public partial class Korisnici
    {
        public List<Uloge> Uloge { get; set; }
    }
}