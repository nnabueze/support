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
    
    public partial class reportslisting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reportslisting()
        {
            this.igrs = new HashSet<igr>();
            this.reportsparameters = new HashSet<reportsparameter>();
        }
    
        public string ID { get; set; }
        public string MenuName { get; set; }
        public string ReportServerURL { get; set; }
        public string MenuUrl { get; set; }
        public string ParentID { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDashboard { get; set; }
        public string RCredentials { get; set; }
        public Nullable<bool> IsAdmin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<igr> igrs { get; set; }
        public virtual igr igr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reportsparameter> reportsparameters { get; set; }
        public virtual rserver rserver { get; set; }
    }
}