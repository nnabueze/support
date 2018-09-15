namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.vw_remittances")]
    public partial class vw_remittances
    {
        [StringLength(1073741823)]
        public string Remittance_id { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(1073741823)]
        public string MDAStation_ID { get; set; }

        public DateTime? create_at { get; set; }

        public DateTime? updated_at { get; set; }

        [StringLength(1073741823)]
        public string MDAStation_Name { get; set; }

        [StringLength(1073741823)]
        public string pos_ID { get; set; }

        [StringLength(1073741823)]
        public string MDA_ID { get; set; }

        [StringLength(1073741823)]
        public string MDA_Name { get; set; }

        [StringLength(16777215)]
        public string Biller_ID { get; set; }

        [StringLength(1073741823)]
        public string User_ID { get; set; }

        [StringLength(16777215)]
        public string remittance_status { get; set; }

        [StringLength(1073741823)]
        public string UserName { get; set; }

        [Key]
        [StringLength(9)]
        public string channel { get; set; }
    }
}
