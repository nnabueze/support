namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.pos_collection")]
    public partial class pos_collection
    {
        [StringLength(38)]
        public string COLLECTION_ID { get; set; }

        public decimal Amount { get; set; }

        [Required]
        [StringLength(38)]
        public string Phone { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(38)]
        public string USER_ID { get; set; }

        [StringLength(38)]
        public string remittance_id { get; set; }

        [StringLength(38)]
        public string MDA_ID { get; set; }

        [Required]
        [StringLength(38)]
        public string MDAStation_ID { get; set; }

        [Required]
        [StringLength(38)]
        public string SubHead_ID { get; set; }

        [Required]
        [StringLength(38)]
        public string POS_ID { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public DateTime? create_at { get; set; }

        public DateTime? updated_at { get; set; }

        public int CollectionType { get; set; }

        public int CollectionStatus { get; set; }

        [Column(TypeName = "uint")]
        public long Id { get; set; }

        [StringLength(45)]
        public string IGR_ID { get; set; }

        [StringLength(255)]
        public string PosCollectionId { get; set; }
    }
}
