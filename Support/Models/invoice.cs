namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.invoices")]
    public partial class invoice
    {
        [Key]
        [StringLength(38)]
        public string invoice_id { get; set; }

        public decimal? amount { get; set; }

        [StringLength(38)]
        public string MDA_ID { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string email { get; set; }

        [StringLength(200)]
        public string phone { get; set; }

        public DateTime? create_at { get; set; }

        public DateTime? updated_at { get; set; }

        [StringLength(200)]
        public string MDAStation_ID { get; set; }

        [StringLength(1073741823)]
        public string USER_ID { get; set; }

        [StringLength(1073741823)]
        public string POS_ID { get; set; }

        [StringLength(50)]
        public string SubHead_ID { get; set; }

        [StringLength(11)]
        public string Type { get; set; }

        [StringLength(11)]
        public string Invoice_Status { get; set; }

        public string AdmissionNo { get; set; }
        public string IGR_Code { get; set; }
    }
}
