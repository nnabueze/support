//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Support
{
    using System;
    using System.Collections.Generic;
    
    public partial class taxpayer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public taxpayer()
        {
            this.assessmenttables = new HashSet<assessmenttable>();
            this.assets = new HashSet<asset>();
            this.assets1 = new HashSet<asset>();
        }
    
        public int TaxPayer_ID { get; set; }
        public string TIN { get; set; }
        public string Surname { get; set; }
        public string OtherNames { get; set; }
        public string BVN { get; set; }
        public string IGR_ID { get; set; }
        public string LocalGovernment { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<int> PayerType { get; set; }
        public string CompanyName { get; set; }
        public string Telephone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assessmenttable> assessmenttables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asset> assets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asset> assets1 { get; set; }
        public virtual igr igr { get; set; }
        public virtual mda mda { get; set; }
        public virtual payertype payertype1 { get; set; }
    }
}
