namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.valueswitchpayments")]
    public partial class valueswitchpayment
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string SessionID { get; set; }

        [Required]
        [StringLength(255)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(255)]
        public string SourceBank { get; set; }

        [Required]
        [StringLength(255)]
        public string DestinationBank { get; set; }

        [StringLength(255)]
        public string BillerID { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(255)]
        public string BillerName { get; set; }

        [StringLength(255)]
        public string CollectRef { get; set; }

        [StringLength(255)]
        public string Narration { get; set; }

        [StringLength(255)]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        public int IsSent { get; set; }

        public DateTime ApprovedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_At { get; set; }

        [StringLength(255)]
        public string CollectionTitle { get; set; }

        [StringLength(255)]
        public string CollectionType { get; set; }
    }
}
