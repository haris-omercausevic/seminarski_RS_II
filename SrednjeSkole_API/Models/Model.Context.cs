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
    }
}
