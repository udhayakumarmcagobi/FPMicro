//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FBMicro.Data.DataProvider
{
    using System;
    using System.Collections.Generic;
    
    public partial class BankMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BankMaster()
        {
            this.BankLoanDetails = new HashSet<BankLoanDetail>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> OfferPercentage { get; set; }
        public string BankLogoPath { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BankLoanDetail> BankLoanDetails { get; set; }
    }
}
