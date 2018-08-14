using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SrednjeSkole_API.Models
{
    public partial class Smjerovi
    {
        public List<Predmeti> Predmeti { get; set; }
    }
}