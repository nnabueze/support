namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.revenueheads")]
    public partial class revenuehead
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public revenuehead()
        {
            subheads = new HashSet<subhead>();
        }

        [StringLength(38)]
        public string ID { get; set; }

        [StringLength(20)]
        public string RevenueCode { get; set; }

        [Required]
        [StringLength(38)]
        public string Biller_ID { get; set; }

        [Required]
        [StringLength(38)]
        public string MDA_ID { get; set; }

        [StringLength(200)]
        public string RevenueName { get; set; }

        public decimal? Amount { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string Taxable { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string AssmentItem { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string IsPOS { get; set; }

        public virtual igr igr { get; set; }

        public virtual mda mda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<subhead> subheads { get; set; }
    }
}
