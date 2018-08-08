﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SrednjeSkoleEntities : DbContext
    {
        public SrednjeSkoleEntities()
            : base("name=SrednjeSkoleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AutorizacijskiToken> AutorizacijskiToken { get; set; }
        public virtual DbSet<Casovi> Casovi { get; set; }
        public virtual DbSet<Izostanci> Izostanci { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Materijali> Materijali { get; set; }
        public virtual DbSet<Obavijesti> Obavijesti { get; set; }
        public virtual DbSet<Predaje> Predaje { get; set; }
        public virtual DbSet<Predmeti> Predmeti { get; set; }
        public virtual DbSet<Razredi> Razredi { get; set; }
        public virtual DbSet<SkolskeGodine> SkolskeGodine { get; set; }
        public virtual DbSet<Smjerovi> Smjerovi { get; set; }
        public virtual DbSet<SmjerPredmet> SmjerPredmet { get; set; }
        public virtual DbSet<UceniciCasovi> UceniciCasovi { get; set; }
        public virtual DbSet<UceniciOcjene> UceniciOcjene { get; set; }
        public virtual DbSet<UceniciRazredi> UceniciRazredi { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
    
        public virtual ObjectResult<Korisnici_Result> ssp_Korisnici_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici_Result>("ssp_Korisnici_SelectAll");
        }
    
        public virtual ObjectResult<Nullable<decimal>> ssp_Korisnici_Insert(string ime, string prezime, string email, string telefon, string korisnickoIme, string lozinkaSalt, string lozinkaHash, string jMBG, Nullable<System.DateTime> datumRodjenja)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            var lozinkaSaltParameter = lozinkaSalt != null ?
                new ObjectParameter("LozinkaSalt", lozinkaSalt) :
                new ObjectParameter("LozinkaSalt", typeof(string));
    
            var lozinkaHashParameter = lozinkaHash != null ?
                new ObjectParameter("LozinkaHash", lozinkaHash) :
                new ObjectParameter("LozinkaHash", typeof(string));
    
            var jMBGParameter = jMBG != null ?
                new ObjectParameter("JMBG", jMBG) :
                new ObjectParameter("JMBG", typeof(string));
    
            var datumRodjenjaParameter = datumRodjenja.HasValue ?
                new ObjectParameter("DatumRodjenja", datumRodjenja) :
                new ObjectParameter("DatumRodjenja", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ssp_Korisnici_Insert", imeParameter, prezimeParameter, emailParameter, telefonParameter, korisnickoImeParameter, lozinkaSaltParameter, lozinkaHashParameter, jMBGParameter, datumRodjenjaParameter);
        }
    
        public virtual ObjectResult<Korisnici_Result> ssp_Korisnici_Pretraga(string ime, string prezime, string email, Nullable<int> ulogaID)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var ulogaIDParameter = ulogaID.HasValue ?
                new ObjectParameter("UlogaID", ulogaID) :
                new ObjectParameter("UlogaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici_Result>("ssp_Korisnici_Pretraga", imeParameter, prezimeParameter, emailParameter, ulogaIDParameter);
        }
    
        public virtual int ssp_Korisnici_Update(Nullable<int> korisnikID, string ime, string prezime, string email, string telefon, string korisnickoIme, string lozinkaSalt, string lozinkaHash, Nullable<bool> aktivan, string jMBG, Nullable<System.DateTime> datumRodjenja)
        {
            var korisnikIDParameter = korisnikID.HasValue ?
                new ObjectParameter("KorisnikID", korisnikID) :
                new ObjectParameter("KorisnikID", typeof(int));
    
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var korisnickoImeParameter = korisnickoIme != null ?
                new ObjectParameter("KorisnickoIme", korisnickoIme) :
                new ObjectParameter("KorisnickoIme", typeof(string));
    
            var lozinkaSaltParameter = lozinkaSalt != null ?
                new ObjectParameter("LozinkaSalt", lozinkaSalt) :
                new ObjectParameter("LozinkaSalt", typeof(string));
    
            var lozinkaHashParameter = lozinkaHash != null ?
                new ObjectParameter("LozinkaHash", lozinkaHash) :
                new ObjectParameter("LozinkaHash", typeof(string));
    
            var aktivanParameter = aktivan.HasValue ?
                new ObjectParameter("Aktivan", aktivan) :
                new ObjectParameter("Aktivan", typeof(bool));
    
            var jMBGParameter = jMBG != null ?
                new ObjectParameter("JMBG", jMBG) :
                new ObjectParameter("JMBG", typeof(string));
    
            var datumRodjenjaParameter = datumRodjenja.HasValue ?
                new ObjectParameter("DatumRodjenja", datumRodjenja) :
                new ObjectParameter("DatumRodjenja", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_Korisnici_Update", korisnikIDParameter, imeParameter, prezimeParameter, emailParameter, telefonParameter, korisnickoImeParameter, lozinkaSaltParameter, lozinkaHashParameter, aktivanParameter, jMBGParameter, datumRodjenjaParameter);
        }
    
        public virtual int ssp_KorisniciUloge_Insert(Nullable<int> korisnikId, Nullable<int> ulogaId)
        {
            var korisnikIdParameter = korisnikId.HasValue ?
                new ObjectParameter("KorisnikId", korisnikId) :
                new ObjectParameter("KorisnikId", typeof(int));
    
            var ulogaIdParameter = ulogaId.HasValue ?
                new ObjectParameter("UlogaId", ulogaId) :
                new ObjectParameter("UlogaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_KorisniciUloge_Insert", korisnikIdParameter, ulogaIdParameter);
        }
    }
}
