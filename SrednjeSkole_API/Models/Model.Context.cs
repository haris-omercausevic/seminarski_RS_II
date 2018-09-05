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
        public virtual DbSet<MaterijaliOcjene> MaterijaliOcjene { get; set; }
    
        public virtual ObjectResult<Korisnici_Result> ssp_Korisnici_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici_Result>("ssp_Korisnici_SelectAll");
        }
    
        public virtual ObjectResult<Nullable<decimal>> ssp_Korisnici_Insert(string ime, string prezime, string email, string telefon, string korisnickoIme, string lozinkaSalt, string lozinkaHash, string jMBG, Nullable<System.DateTime> datumRodjenja, byte[] slika, byte[] slikaThumb)
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
    
            var slikaParameter = slika != null ?
                new ObjectParameter("Slika", slika) :
                new ObjectParameter("Slika", typeof(byte[]));
    
            var slikaThumbParameter = slikaThumb != null ?
                new ObjectParameter("SlikaThumb", slikaThumb) :
                new ObjectParameter("SlikaThumb", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ssp_Korisnici_Insert", imeParameter, prezimeParameter, emailParameter, telefonParameter, korisnickoImeParameter, lozinkaSaltParameter, lozinkaHashParameter, jMBGParameter, datumRodjenjaParameter, slikaParameter, slikaThumbParameter);
        }
    
        public virtual ObjectResult<KorisniciPretraga_Result> ssp_Korisnici_Pretraga(string ime, string prezime, Nullable<int> ulogaID)
        {
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var ulogaIDParameter = ulogaID.HasValue ?
                new ObjectParameter("UlogaID", ulogaID) :
                new ObjectParameter("UlogaID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KorisniciPretraga_Result>("ssp_Korisnici_Pretraga", imeParameter, prezimeParameter, ulogaIDParameter);
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
    
        public virtual int ssp_KorisniciUloge_Remove(Nullable<int> korisnikId)
        {
            var korisnikIdParameter = korisnikId.HasValue ?
                new ObjectParameter("KorisnikId", korisnikId) :
                new ObjectParameter("KorisnikId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_KorisniciUloge_Remove", korisnikIdParameter);
        }
    
        public virtual ObjectResult<Korisnici_Result> ssp_Korisnici_GetById(Nullable<int> korisnikId)
        {
            var korisnikIdParameter = korisnikId.HasValue ?
                new ObjectParameter("korisnikId", korisnikId) :
                new ObjectParameter("korisnikId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Korisnici_Result>("ssp_Korisnici_GetById", korisnikIdParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> ssp_Smjerovi_Insert(string naziv, string opis, Nullable<int> skolskaGodinaId)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var opisParameter = opis != null ?
                new ObjectParameter("Opis", opis) :
                new ObjectParameter("Opis", typeof(string));
    
            var skolskaGodinaIdParameter = skolskaGodinaId.HasValue ?
                new ObjectParameter("SkolskaGodinaId", skolskaGodinaId) :
                new ObjectParameter("SkolskaGodinaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ssp_Smjerovi_Insert", nazivParameter, opisParameter, skolskaGodinaIdParameter);
        }
    
        public virtual int ssp_SmjerPredmet_Insert(Nullable<int> smjerId, Nullable<int> predmetId, Nullable<int> brojCasova)
        {
            var smjerIdParameter = smjerId.HasValue ?
                new ObjectParameter("SmjerId", smjerId) :
                new ObjectParameter("SmjerId", typeof(int));
    
            var predmetIdParameter = predmetId.HasValue ?
                new ObjectParameter("PredmetId", predmetId) :
                new ObjectParameter("PredmetId", typeof(int));
    
            var brojCasovaParameter = brojCasova.HasValue ?
                new ObjectParameter("BrojCasova", brojCasova) :
                new ObjectParameter("BrojCasova", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_SmjerPredmet_Insert", smjerIdParameter, predmetIdParameter, brojCasovaParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> ssp_Razredi_Insert(Nullable<int> razredBrojcano, string odjeljenje, string oznaka, Nullable<int> skolskaGodinaId, Nullable<int> nastavnikId, Nullable<int> smjerId)
        {
            var razredBrojcanoParameter = razredBrojcano.HasValue ?
                new ObjectParameter("RazredBrojcano", razredBrojcano) :
                new ObjectParameter("RazredBrojcano", typeof(int));
    
            var odjeljenjeParameter = odjeljenje != null ?
                new ObjectParameter("Odjeljenje", odjeljenje) :
                new ObjectParameter("Odjeljenje", typeof(string));
    
            var oznakaParameter = oznaka != null ?
                new ObjectParameter("Oznaka", oznaka) :
                new ObjectParameter("Oznaka", typeof(string));
    
            var skolskaGodinaIdParameter = skolskaGodinaId.HasValue ?
                new ObjectParameter("SkolskaGodinaId", skolskaGodinaId) :
                new ObjectParameter("SkolskaGodinaId", typeof(int));
    
            var nastavnikIdParameter = nastavnikId.HasValue ?
                new ObjectParameter("NastavnikId", nastavnikId) :
                new ObjectParameter("NastavnikId", typeof(int));
    
            var smjerIdParameter = smjerId.HasValue ?
                new ObjectParameter("SmjerId", smjerId) :
                new ObjectParameter("SmjerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ssp_Razredi_Insert", razredBrojcanoParameter, odjeljenjeParameter, oznakaParameter, skolskaGodinaIdParameter, nastavnikIdParameter, smjerIdParameter);
        }
    
        public virtual int ssp_Nastavnici_Insert(Nullable<int> id, string zvanje, string naucnaOblast, Nullable<int> godinaZaposlenja)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var zvanjeParameter = zvanje != null ?
                new ObjectParameter("Zvanje", zvanje) :
                new ObjectParameter("Zvanje", typeof(string));
    
            var naucnaOblastParameter = naucnaOblast != null ?
                new ObjectParameter("NaucnaOblast", naucnaOblast) :
                new ObjectParameter("NaucnaOblast", typeof(string));
    
            var godinaZaposlenjaParameter = godinaZaposlenja.HasValue ?
                new ObjectParameter("GodinaZaposlenja", godinaZaposlenja) :
                new ObjectParameter("GodinaZaposlenja", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_Nastavnici_Insert", idParameter, zvanjeParameter, naucnaOblastParameter, godinaZaposlenjaParameter);
        }
    
        public virtual int ssp_Ucenici_Insert(Nullable<int> id, string imeRoditelja, Nullable<int> godinaUpisa, Nullable<int> smjerId, string nazivOsnovneSkole)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var imeRoditeljaParameter = imeRoditelja != null ?
                new ObjectParameter("ImeRoditelja", imeRoditelja) :
                new ObjectParameter("ImeRoditelja", typeof(string));
    
            var godinaUpisaParameter = godinaUpisa.HasValue ?
                new ObjectParameter("GodinaUpisa", godinaUpisa) :
                new ObjectParameter("GodinaUpisa", typeof(int));
    
            var smjerIdParameter = smjerId.HasValue ?
                new ObjectParameter("SmjerId", smjerId) :
                new ObjectParameter("SmjerId", typeof(int));
    
            var nazivOsnovneSkoleParameter = nazivOsnovneSkole != null ?
                new ObjectParameter("NazivOsnovneSkole", nazivOsnovneSkole) :
                new ObjectParameter("NazivOsnovneSkole", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_Ucenici_Insert", idParameter, imeRoditeljaParameter, godinaUpisaParameter, smjerIdParameter, nazivOsnovneSkoleParameter);
        }
    
        public virtual ObjectResult<Predmeti_Result> ssp_Predmeti_GetById(Nullable<int> predmetId)
        {
            var predmetIdParameter = predmetId.HasValue ?
                new ObjectParameter("predmetId", predmetId) :
                new ObjectParameter("predmetId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Predmeti_Result>("ssp_Predmeti_GetById", predmetIdParameter);
        }
    
        public virtual ObjectResult<Predmeti_Result> ssp_Predmeti_GetByRazred(Nullable<int> razred)
        {
            var razredParameter = razred.HasValue ?
                new ObjectParameter("razred", razred) :
                new ObjectParameter("razred", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Predmeti_Result>("ssp_Predmeti_GetByRazred", razredParameter);
        }
    
        public virtual ObjectResult<Materijali_Result> ssp_Materijali_GetByPredmetId(Nullable<int> predmetId)
        {
            var predmetIdParameter = predmetId.HasValue ?
                new ObjectParameter("predmetId", predmetId) :
                new ObjectParameter("predmetId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Materijali_Result>("ssp_Materijali_GetByPredmetId", predmetIdParameter);
        }
    
        public virtual ObjectResult<Uloga_Result> ssp_Uloge_GetByKorisnikId(Nullable<int> korisnikId)
        {
            var korisnikIdParameter = korisnikId.HasValue ?
                new ObjectParameter("KorisnikId", korisnikId) :
                new ObjectParameter("KorisnikId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Uloga_Result>("ssp_Uloge_GetByKorisnikId", korisnikIdParameter);
        }
    
        public virtual ObjectResult<Obavijesti_Result> ssp_Obavijesti_GetById(Nullable<int> obavijestId)
        {
            var obavijestIdParameter = obavijestId.HasValue ?
                new ObjectParameter("ObavijestId", obavijestId) :
                new ObjectParameter("ObavijestId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Obavijesti_Result>("ssp_Obavijesti_GetById", obavijestIdParameter);
        }
    
        public virtual int ssp_Obavijesti_Insert(string naslov, string tekst, Nullable<int> korisnikId, Nullable<System.DateTime> datum)
        {
            var naslovParameter = naslov != null ?
                new ObjectParameter("Naslov", naslov) :
                new ObjectParameter("Naslov", typeof(string));
    
            var tekstParameter = tekst != null ?
                new ObjectParameter("Tekst", tekst) :
                new ObjectParameter("Tekst", typeof(string));
    
            var korisnikIdParameter = korisnikId.HasValue ?
                new ObjectParameter("KorisnikId", korisnikId) :
                new ObjectParameter("KorisnikId", typeof(int));
    
            var datumParameter = datum.HasValue ?
                new ObjectParameter("Datum", datum) :
                new ObjectParameter("Datum", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_Obavijesti_Insert", naslovParameter, tekstParameter, korisnikIdParameter, datumParameter);
        }
    
        public virtual ObjectResult<Obavijesti_Result> ssp_Obavijesti_Pretraga(string naslov)
        {
            var naslovParameter = naslov != null ?
                new ObjectParameter("naslov", naslov) :
                new ObjectParameter("naslov", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Obavijesti_Result>("ssp_Obavijesti_Pretraga", naslovParameter);
        }
    
        public virtual ObjectResult<Obavijesti_Result> ssp_Obavijesti_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Obavijesti_Result>("ssp_Obavijesti_SelectAll");
        }
    
        public virtual int ssp_Obavijesti_Update(Nullable<int> obavijestId, string naslov, string tekst, Nullable<System.DateTime> datum)
        {
            var obavijestIdParameter = obavijestId.HasValue ?
                new ObjectParameter("ObavijestId", obavijestId) :
                new ObjectParameter("ObavijestId", typeof(int));
    
            var naslovParameter = naslov != null ?
                new ObjectParameter("Naslov", naslov) :
                new ObjectParameter("Naslov", typeof(string));
    
            var tekstParameter = tekst != null ?
                new ObjectParameter("Tekst", tekst) :
                new ObjectParameter("Tekst", typeof(string));
    
            var datumParameter = datum.HasValue ?
                new ObjectParameter("Datum", datum) :
                new ObjectParameter("Datum", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_Obavijesti_Update", obavijestIdParameter, naslovParameter, tekstParameter, datumParameter);
        }
    
        public virtual ObjectResult<Razredi_Result> ssp_Razredi_Pretraga(string oznaka)
        {
            var oznakaParameter = oznaka != null ?
                new ObjectParameter("oznaka", oznaka) :
                new ObjectParameter("oznaka", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Razredi_Result>("ssp_Razredi_Pretraga", oznakaParameter);
        }
    
        public virtual ObjectResult<UceniciRazredi_Result> ssp_UceniciRazredi_GetByRazredId(Nullable<int> razredId)
        {
            var razredIdParameter = razredId.HasValue ?
                new ObjectParameter("RazredId", razredId) :
                new ObjectParameter("RazredId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UceniciRazredi_Result>("ssp_UceniciRazredi_GetByRazredId", razredIdParameter);
        }
    
        public virtual ObjectResult<Predaje_Result> ssp_Predaje_GetByNastavnikRazred(Nullable<int> nastavnikId, Nullable<int> razredId)
        {
            var nastavnikIdParameter = nastavnikId.HasValue ?
                new ObjectParameter("NastavnikId", nastavnikId) :
                new ObjectParameter("NastavnikId", typeof(int));
    
            var razredIdParameter = razredId.HasValue ?
                new ObjectParameter("RazredId", razredId) :
                new ObjectParameter("RazredId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Predaje_Result>("ssp_Predaje_GetByNastavnikRazred", nastavnikIdParameter, razredIdParameter);
        }
    
        public virtual int ssp_UceniciOcjene_Insert(Nullable<int> predajeId, Nullable<int> ucenikId, Nullable<int> vrijednost, Nullable<System.DateTime> datum, string napomena)
        {
            var predajeIdParameter = predajeId.HasValue ?
                new ObjectParameter("PredajeId", predajeId) :
                new ObjectParameter("PredajeId", typeof(int));
    
            var ucenikIdParameter = ucenikId.HasValue ?
                new ObjectParameter("UcenikId", ucenikId) :
                new ObjectParameter("UcenikId", typeof(int));
    
            var vrijednostParameter = vrijednost.HasValue ?
                new ObjectParameter("Vrijednost", vrijednost) :
                new ObjectParameter("Vrijednost", typeof(int));
    
            var datumParameter = datum.HasValue ?
                new ObjectParameter("Datum", datum) :
                new ObjectParameter("Datum", typeof(System.DateTime));
    
            var napomenaParameter = napomena != null ?
                new ObjectParameter("Napomena", napomena) :
                new ObjectParameter("Napomena", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_UceniciOcjene_Insert", predajeIdParameter, ucenikIdParameter, vrijednostParameter, datumParameter, napomenaParameter);
        }
    
        public virtual ObjectResult<Nastavnici_Result> ssp_Nastavnici_SelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nastavnici_Result>("ssp_Nastavnici_SelectAll");
        }
    
        public virtual ObjectResult<Razredi_Result> ssp_Razredi_GetAktivni()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Razredi_Result>("ssp_Razredi_GetAktivni");
        }
    
        public virtual ObjectResult<Nastavnici_Result> ssp_Nastavnici_NotRazrednici()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nastavnici_Result>("ssp_Nastavnici_NotRazrednici");
        }
    
        public virtual int ssp_Materijali_Insert(string naziv, string blobName, string url, Nullable<System.DateTime> dateCreated, Nullable<int> predmetId, Nullable<int> nastavnikId, Nullable<decimal> rating, Nullable<int> brojOcjena)
        {
            var nazivParameter = naziv != null ?
                new ObjectParameter("Naziv", naziv) :
                new ObjectParameter("Naziv", typeof(string));
    
            var blobNameParameter = blobName != null ?
                new ObjectParameter("BlobName", blobName) :
                new ObjectParameter("BlobName", typeof(string));
    
            var urlParameter = url != null ?
                new ObjectParameter("Url", url) :
                new ObjectParameter("Url", typeof(string));
    
            var dateCreatedParameter = dateCreated.HasValue ?
                new ObjectParameter("DateCreated", dateCreated) :
                new ObjectParameter("DateCreated", typeof(System.DateTime));
    
            var predmetIdParameter = predmetId.HasValue ?
                new ObjectParameter("PredmetId", predmetId) :
                new ObjectParameter("PredmetId", typeof(int));
    
            var nastavnikIdParameter = nastavnikId.HasValue ?
                new ObjectParameter("NastavnikId", nastavnikId) :
                new ObjectParameter("NastavnikId", typeof(int));
    
            var ratingParameter = rating.HasValue ?
                new ObjectParameter("Rating", rating) :
                new ObjectParameter("Rating", typeof(decimal));
    
            var brojOcjenaParameter = brojOcjena.HasValue ?
                new ObjectParameter("BrojOcjena", brojOcjena) :
                new ObjectParameter("BrojOcjena", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_Materijali_Insert", nazivParameter, blobNameParameter, urlParameter, dateCreatedParameter, predmetIdParameter, nastavnikIdParameter, ratingParameter, brojOcjenaParameter);
        }
    
        public virtual ObjectResult<Predaje_Result> ssp_Predaje_GetByNastavnik(Nullable<int> nastavnikId)
        {
            var nastavnikIdParameter = nastavnikId.HasValue ?
                new ObjectParameter("NastavnikId", nastavnikId) :
                new ObjectParameter("NastavnikId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Predaje_Result>("ssp_Predaje_GetByNastavnik", nastavnikIdParameter);
        }
    
        public virtual int ssp_Predaje_Insert(Nullable<int> nastavnikId, Nullable<int> predmetId, Nullable<int> razredId)
        {
            var nastavnikIdParameter = nastavnikId.HasValue ?
                new ObjectParameter("NastavnikId", nastavnikId) :
                new ObjectParameter("NastavnikId", typeof(int));
    
            var predmetIdParameter = predmetId.HasValue ?
                new ObjectParameter("PredmetId", predmetId) :
                new ObjectParameter("PredmetId", typeof(int));
    
            var razredIdParameter = razredId.HasValue ?
                new ObjectParameter("RazredId", razredId) :
                new ObjectParameter("RazredId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_Predaje_Insert", nastavnikIdParameter, predmetIdParameter, razredIdParameter);
        }
    
        public virtual int ssp_UceniciRazredi_Insert(Nullable<int> redniBroj, string skolskaGodina, Nullable<int> ucenikId, Nullable<int> razredID)
        {
            var redniBrojParameter = redniBroj.HasValue ?
                new ObjectParameter("RedniBroj", redniBroj) :
                new ObjectParameter("RedniBroj", typeof(int));
    
            var skolskaGodinaParameter = skolskaGodina != null ?
                new ObjectParameter("SkolskaGodina", skolskaGodina) :
                new ObjectParameter("SkolskaGodina", typeof(string));
    
            var ucenikIdParameter = ucenikId.HasValue ?
                new ObjectParameter("UcenikId", ucenikId) :
                new ObjectParameter("UcenikId", typeof(int));
    
            var razredIDParameter = razredID.HasValue ?
                new ObjectParameter("RazredID", razredID) :
                new ObjectParameter("RazredID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_UceniciRazredi_Insert", redniBrojParameter, skolskaGodinaParameter, ucenikIdParameter, razredIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> ssp_MaterijaliOcjene_Insert(Nullable<int> materijalId, Nullable<int> ucenikId, Nullable<int> ocjena)
        {
            var materijalIdParameter = materijalId.HasValue ?
                new ObjectParameter("MaterijalId", materijalId) :
                new ObjectParameter("MaterijalId", typeof(int));
    
            var ucenikIdParameter = ucenikId.HasValue ?
                new ObjectParameter("UcenikId", ucenikId) :
                new ObjectParameter("UcenikId", typeof(int));
    
            var ocjenaParameter = ocjena.HasValue ?
                new ObjectParameter("Ocjena", ocjena) :
                new ObjectParameter("Ocjena", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("ssp_MaterijaliOcjene_Insert", materijalIdParameter, ucenikIdParameter, ocjenaParameter);
        }
    
        public virtual int ssp_Materijali_UpdateOcjene(Nullable<int> materijalId)
        {
            var materijalIdParameter = materijalId.HasValue ?
                new ObjectParameter("MaterijalId", materijalId) :
                new ObjectParameter("MaterijalId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ssp_Materijali_UpdateOcjene", materijalIdParameter);
        }
    
        public virtual ObjectResult<UceniciOcjene_Result> ssp_UceniciOcjene_GetByUcenikRazred(Nullable<int> ucenikId, Nullable<int> razredId)
        {
            var ucenikIdParameter = ucenikId.HasValue ?
                new ObjectParameter("UcenikId", ucenikId) :
                new ObjectParameter("UcenikId", typeof(int));
    
            var razredIdParameter = razredId.HasValue ?
                new ObjectParameter("RazredId", razredId) :
                new ObjectParameter("RazredId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UceniciOcjene_Result>("ssp_UceniciOcjene_GetByUcenikRazred", ucenikIdParameter, razredIdParameter);
        }
    
        public virtual ObjectResult<string> ssp_UceniciRazredi_GetRazrediUcenika(Nullable<int> ucenikId)
        {
            var ucenikIdParameter = ucenikId.HasValue ?
                new ObjectParameter("UcenikId", ucenikId) :
                new ObjectParameter("UcenikId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ssp_UceniciRazredi_GetRazrediUcenika", ucenikIdParameter);
        }
    
        public virtual ObjectResult<Materijali_Result> ssp_Materijali_GetByRazredPreporuka(Nullable<int> razred)
        {
            var razredParameter = razred.HasValue ?
                new ObjectParameter("razred", razred) :
                new ObjectParameter("razred", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Materijali_Result>("ssp_Materijali_GetByRazredPreporuka", razredParameter);
        }
    
        public virtual ObjectResult<RazredIzvjestaj_Result> ssp_UceniciOcjene_GetRazredIzvjestaj(Nullable<int> razredId)
        {
            var razredIdParameter = razredId.HasValue ?
                new ObjectParameter("RazredId", razredId) :
                new ObjectParameter("RazredId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RazredIzvjestaj_Result>("ssp_UceniciOcjene_GetRazredIzvjestaj", razredIdParameter);
        }
    
        public virtual ObjectResult<Materijali_Result> ssp_Materijali_GetByRazredPreporukaKonfigurabilna(Nullable<int> razred, Nullable<decimal> brojOcjenaFaktor, Nullable<decimal> ratingFaktor)
        {
            var razredParameter = razred.HasValue ?
                new ObjectParameter("razred", razred) :
                new ObjectParameter("razred", typeof(int));
    
            var brojOcjenaFaktorParameter = brojOcjenaFaktor.HasValue ?
                new ObjectParameter("brojOcjenaFaktor", brojOcjenaFaktor) :
                new ObjectParameter("brojOcjenaFaktor", typeof(decimal));
    
            var ratingFaktorParameter = ratingFaktor.HasValue ?
                new ObjectParameter("ratingFaktor", ratingFaktor) :
                new ObjectParameter("ratingFaktor", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Materijali_Result>("ssp_Materijali_GetByRazredPreporukaKonfigurabilna", razredParameter, brojOcjenaFaktorParameter, ratingFaktorParameter);
        }
    
        public virtual ObjectResult<string> ssp_UceniciRazredi_GetRazrediBrojcanoUcenika(Nullable<int> ucenikId)
        {
            var ucenikIdParameter = ucenikId.HasValue ?
                new ObjectParameter("UcenikId", ucenikId) :
                new ObjectParameter("UcenikId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ssp_UceniciRazredi_GetRazrediBrojcanoUcenika", ucenikIdParameter);
        }
    }
}
