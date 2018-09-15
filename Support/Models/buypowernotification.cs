namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.buypowernotifications")]
    public partial class buypowernotification
    {
        public int Id { get; set; }

        [StringLength(1073741823)]
        public string Phone { get; set; }

        [StringLength(1073741823)]
        public string Amount { get; set; }

        [StringLength(1073741823)]
        public string Email { get; set; }

        [StringLength(1073741823)]
        public string Name { get; set; }

        [StringLength(1073741823)]
        public string SessionID { get; set; }

        [StringLength(1073741823)]
        public string BillerID { get; set; }

        [StringLength(1073741823)]
        public string BillerName { get; set; }

        [StringLength(1073741823)]
        public string ProductName { get; set; }

        [StringLength(1073741823)]
        public string SourceBankCode { get; set; }

        [StringLength(1073741823)]
        public string ProductID { get; set; }

        [StringLength(1073741823)]
        public string DestinationBankCode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? EntryDate { get; set; }

        [Required]
        [StringLength(255)]
        public string meterNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string discoCode { get; set; }

        [StringLength(255)]
        public string Token { get; set; }

        [StringLength(255)]
        public string vendRef { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime created_at { get; set; }
    }
}
