namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.reportslisting")]
    public partial class reportslisting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public reportslisting()
        {
            igrs = new HashSet<igr>();
            reportsparameters = new HashSet<reportsparameter>();
        }

        [StringLength(38)]
        public string ID { get; set; }

        [StringLength(50)]
        public string MenuName { get; set; }

        [StringLength(200)]
        public string ReportServerURL { get; set; }

        [StringLength(200)]
        public string MenuUrl { get; set; }

        [StringLength(38)]
        public string ParentID { get; set; }

        [StringLength(38)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsDashboard { get; set; }

        [StringLength(38)]
        public string RCredentials { get; set; }

        [Column(TypeName = "bit")]
        public bool? IsAdmin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<igr> igrs { get; set; }

        public virtual igr igr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reportsparameter> reportsparameters { get; set; }

        public virtual rserver rserver { get; set; }
    }
}
