namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.pos")]
    public partial class pos
    {
        [Key]
        [StringLength(38)]
        public string POS_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string POS_imei { get; set; }

        [StringLength(100)]
        public string POS_Name { get; set; }

        [StringLength(50)]
        public string ActivationCode { get; set; }

        [Column(TypeName = "bit")]
        public bool? Activation { get; set; }

        [StringLength(38)]
        public string MDA_ID { get; set; }

        [StringLength(38)]
        public string Station_ID { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual mda mda { get; set; }

        public virtual mda_stations mda_stations { get; set; }
    }
}
