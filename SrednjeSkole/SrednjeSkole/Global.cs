using SrednjeSkole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SrednjeSkole
{
    public class Global
    {
        public static Korisnici prijavljeniKorisnik { get; set; }
        public static string APIAddres { get; } = "https://srednjeskoleapi20180818082926.azurewebsites.net";
    }
}
