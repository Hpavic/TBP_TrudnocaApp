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
    
    public partial class MedicinaPovijest
    {
        public int IdMedicine { get; set; }
        public Nullable<int> IdKorisnika { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
        public System.DateTime VrijediOd { get; set; }
        public System.DateTime VrijediDo { get; set; }
    }
}
