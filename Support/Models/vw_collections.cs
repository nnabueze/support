namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.vw_collections")]
    public partial class vw_collections
    {
        [StringLength(255)]
        public string Collection_ID { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(38)]
        public string subhead_ID { get; set; }

        [StringLength(38)]
        public string MDAStation_ID { get; set; }

        public DateTime? create_at { get; set; }

        public DateTime? updated_at { get; set; }

        [StringLength(100)]
        public string MDAStation_Name { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(38)]
        public string pos_ID { get; set; }

        [StringLength(38)]
        public string MDA_ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long collectionType { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CollectionStatus { get; set; }

        [StringLength(256)]
        public string User_ID { get; set; }

        [StringLength(250)]
        public string SubHead_Name { get; set; }

        [StringLength(250)]
        public string SubHead_Code { get; set; }

        [StringLength(250)]
        public string RevenueCode { get; set; }

        [StringLength(250)]
        public string RevenueName { get; set; }

        [StringLength(38)]
        public string Biller_ID { get; set; }

        [StringLength(255)]
        public string RevenueHead_ID { get; set; }

        [StringLength(38)]
        public string Remittance_id { get; set; }

        [StringLength(100)]
        public string MDA_Name { get; set; }

        [StringLength(200)]
        public string Name { get; set; }
    }
}
