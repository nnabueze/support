namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.abuthpaymentitems")]
    public partial class abuthpaymentitem
    {
        [Column(TypeName = "uint")]
        public long Id { get; set; }

        [Required]
        [StringLength(255)]
        public string ItemId { get; set; }

        [Required]
        [StringLength(255)]
        public string TransId { get; set; }

        [Required]
        [StringLength(255)]
        public string ServiceId { get; set; }

        [Required]
        [StringLength(255)]
        public string ServiceName { get; set; }

        [Required]
        [StringLength(255)]
        public string DepartmentId { get; set; }

        public decimal Amount { get; set; }

        [StringLength(255)]
        public string Quantity { get; set; }

        public DateTime Create_At { get; set; }

        [StringLength(255)]
        public string offlineTransId { get; set; }
    }
}
