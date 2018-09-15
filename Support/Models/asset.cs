namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.asset")]
    public partial class asset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public asset()
        {
            assessmenttables = new HashSet<assessmenttable>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Asset_ID { get; set; }

        [StringLength(100)]
        public string AssetName { get; set; }

        [StringLength(150)]
        public string ImagePath { get; set; }

        [StringLength(45)]
        public string AssetType { get; set; }

        public int? TaxPayer { get; set; }

        [StringLength(38)]
        public string LGA { get; set; }

        public int? CompanyName { get; set; }

        [StringLength(38)]
        public string IGR_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assessmenttable> assessmenttables { get; set; }

        public virtual taxpayer taxpayer1 { get; set; }

        public virtual igr igr { get; set; }

        public virtual mda mda { get; set; }

        public virtual taxpayer taxpayer2 { get; set; }
    }
}
