//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TBP_Hrvoje_Trudnoca_app
{
    using System;
    using System.Collections.Generic;
    
    public partial class NajdraziUdarci
    {
        public int Id { get; set; }
        public int IdIntervala { get; set; }
        public System.DateTime Datum { get; set; }
        public Nullable<System.TimeSpan> PocetakIntervala { get; set; }
        public Nullable<int> RedniBrojUdarca { get; set; }
        public Nullable<System.TimeSpan> VrijemeUdarca { get; set; }
        public Nullable<System.TimeSpan> KrajIntervala { get; set; }
        public Nullable<int> IdKorisnika { get; set; }
    
        public virtual Korisnici Korisnici { get; set; }
    }
}
