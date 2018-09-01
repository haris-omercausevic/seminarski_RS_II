using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole.Models
{
    public class MaterijaliOcjene
    {
        public int MaterijaliOcjeneId { get; set; }
        public int MaterijalId { get; set; }
        public int UcenikId { get; set; }
        public int Ocjena { get; set; }
    }
}
