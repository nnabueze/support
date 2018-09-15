namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.taxpayer")]
    public partial class taxpayer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public taxpayer()
        {
            assessmenttables = new HashSet<assessmenttable>();
            assets = new HashSet<asset>();
            assets1 = new HashSet<asset>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaxPayer_ID { get; set; }

        [StringLength(45)]
        public string TIN { get; set; }

        [StringLength(45)]
        public string Surname { get; set; }

        [StringLength(100)]
        public string OtherNames { get; set; }

        [StringLength(45)]
        public string BVN { get; set; }

        [StringLength(38)]
        public string IGR_ID { get; set; }

        [StringLength(38)]
        public string LocalGovernment { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }

        public int? PayerType { get; set; }

        [StringLength(200)]
        public string CompanyName { get; set; }

        [StringLength(45)]
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
