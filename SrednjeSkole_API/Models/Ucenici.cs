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
    using System.Collections.Generic;
    
    public partial class Ucenici : Korisnici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ucenici()
        {
            this.Izostanci = new HashSet<Izostanci>();
            this.UceniciCasovi = new HashSet<UceniciCasovi>();
            this.UceniciOcjene = new HashSet<UceniciOcjene>();
            this.UceniciRazredi = new HashSet<UceniciRazredi>();
            this.MaterijaliOcjene = new HashSet<MaterijaliOcjene>();
        }
    
        public string ImeRoditelja { get; set; }
        public int GodinaUpisa { get; set; }
        public int SmjerId { get; set; }
        public string NazivOsnovneSkole { get; set; }
        public Nullable<double> ProsjekOcjenaOsnovnaSkola { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Izostanci> Izostanci { get; set; }
        public virtual Smjerovi Smjerovi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UceniciCasovi> UceniciCasovi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UceniciOcjene> UceniciOcjene { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UceniciRazredi> UceniciRazredi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterijaliOcjene> MaterijaliOcjene { get; set; }
    }
}
