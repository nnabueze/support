namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.kedcopayments")]
    public partial class kedcopayment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string TransactionId { get; set; }

        [Required]
        [StringLength(255)]
        public string UserId { get; set; }

        [Required]
        [StringLength(255)]
        public string PosId { get; set; }

        [StringLength(255)]
        public string SubHead_ID { get; set; }

        [Required]
        [StringLength(255)]
        public string AccountNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string MeterType { get; set; }

        [StringLength(255)]
        public string PaymentMode { get; set; }

        [Required]
        [StringLength(255)]
        public string TranactionDate { get; set; }

        [StringLength(255)]
        public string TransactionReference { get; set; }

        [StringLength(255)]
        public string LastTransactionDate { get; set; }

        [Required]
        [StringLength(255)]
        public string StationId { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        [StringLength(255)]
        public string CustomerPhone { get; set; }

        public decimal Amount { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string Status { get; set; }

        [StringLength(255)]
        public string ReceiptNumber { get; set; }

        [Column(TypeName = "enum")]
        [StringLength(65532)]
        public string TransactionType { get; set; }

        [StringLength(255)]
        public string CustomerArears { get; set; }

        public bool IsRemitted { get; set; }

        [StringLength(255)]
        public string RemittanceId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(20)]
        public string tariffCode { get; set; }
    }
}
