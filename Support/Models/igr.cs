namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.igr")]
    public partial class igr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public igr()
        {
            assessmenttables = new HashSet<assessmenttable>();
            assets = new HashSet<asset>();
            taxpayers = new HashSet<taxpayer>();
            reportslistings = new HashSet<reportslisting>();
            mdas = new HashSet<mda>();
            revenueheads = new HashSet<revenuehead>();
        }

        [Key]
        [StringLength(38)]
        public string IGR_Code { get; set; }

        [StringLength(200)]
        public string IGR_Name { get; set; }

        [StringLength(100)]
        public string Logo { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateUpdated { get; set; }

        [Column(TypeName = "bit")]
        public bool IsIGR { get; set; }

        [StringLength(38)]
        public string Dashboard { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(45)]
        public string Telephone { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(45)]
        public string IS_IGRCode { get; set; }

        [StringLength(45)]
        public string CategoryName { get; set; }

        [StringLength(45)]
        public string CategoryUrl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assessmenttable> assessmenttables { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asset> assets { get; set; }

        public virtual reportslisting reportslisting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<taxpayer> taxpayers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reportslisting> reportslistings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mda> mdas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<revenuehead> revenueheads { get; set; }
    }
}
