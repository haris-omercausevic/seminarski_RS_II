//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SrednjeSkole_API.Models
{
    using System;
    
    public partial class Korisnici_Result
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Uloga { get; set; }
        public Nullable<System.DateTime> DatumRodjenja { get; set; }
        public string JMBG { get; set; }
        public string Telefon { get; set; }
    }
}
