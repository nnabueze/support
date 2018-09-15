namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.oneclickpayments")]
    public partial class oneclickpayment
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string SessionID { get; set; }

        [StringLength(255)]
        public string PayerName { get; set; }

        [StringLength(255)]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        public string Disco { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string SourceBank { get; set; }

        [StringLength(255)]
        public string DestinationBank { get; set; }

        public int IsSent { get; set; }

        public DateTime ApprovedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_At { get; set; }

        [Required]
        [StringLength(45)]
        public string MeterNumber { get; set; }

        public decimal Amount { get; set; }
    }
}
