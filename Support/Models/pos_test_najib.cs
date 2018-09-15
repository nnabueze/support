namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.pos_test_najib")]
    public partial class pos_test_najib
    {
        [StringLength(38)]
        public string COLLECTION_ID { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(38)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(38)]
        public string USER_ID { get; set; }

        [StringLength(38)]
        public string remittance_id { get; set; }

        [StringLength(38)]
        public string MDA_ID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(38)]
        public string MDAStation_ID { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(38)]
        public string SubHead_ID { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(38)]
        public string POS_ID { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public DateTime? create_at { get; set; }

        public DateTime? updated_at { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CollectionType { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CollectionStatus { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
    }
}
