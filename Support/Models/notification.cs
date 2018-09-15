namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.notification")]
    public partial class notification
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string sessionID { get; set; }

        [StringLength(50)]
        public string SourceBankCode { get; set; }

        [StringLength(50)]
        public string DestinationBankCode { get; set; }

        [StringLength(200)]
        public string phone { get; set; }

        public decimal? amount { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(38)]
        public string IGR_Code { get; set; }

        [StringLength(38)]
        public string MDA_ID { get; set; }

        [StringLength(38)]
        public string SubHead_ID { get; set; }

        [StringLength(255)]
        public string SourceBankName { get; set; }

        [StringLength(255)]
        public string MDAStation_ID { get; set; }

        [StringLength(255)]
        public string payerid { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        [StringLength(100)]
        public string tin { get; set; }

        [StringLength(38)]
        public string remittance_id { get; set; }

        [StringLength(38)]
        public string invoice_id { get; set; }

        [StringLength(200)]
        public string refcode { get; set; }

        [StringLength(250)]
        public string productType { get; set; }

        public DateTime? create_at { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? ApprovedDate { get; set; }
    }
}
