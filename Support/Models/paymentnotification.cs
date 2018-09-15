namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.paymentnotifications")]
    public partial class paymentnotification
    {
        public int Id { get; set; }

        [StringLength(1073741823)]
        public string SessionID { get; set; }

        [StringLength(1073741823)]
        public string RequestorID { get; set; }

        [StringLength(1073741823)]
        public string PayerPhoneNumber { get; set; }

        [StringLength(1073741823)]
        public string PayerName { get; set; }

        [StringLength(1073741823)]
        public string MerchantCode { get; set; }

        [StringLength(1073741823)]
        public string MerchantName { get; set; }

        [StringLength(1073741823)]
        public string MerchantPhoneNumber { get; set; }

        [StringLength(1073741823)]
        public string ReferenceCode { get; set; }

        [StringLength(1073741823)]
        public string Amount { get; set; }

        [StringLength(1073741823)]
        public string TransactionDate { get; set; }

        [StringLength(1073741823)]
        public string ResponseCode { get; set; }

        [Column(TypeName = "enum")]
        [Required]
        [StringLength(65532)]
        public string sent_status { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime created_at { get; set; }
    }
}
