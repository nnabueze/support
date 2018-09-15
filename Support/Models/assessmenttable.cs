namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.assessmenttable")]
    public partial class assessmenttable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Assessment_ID { get; set; }

        public DateTime? AssessmentDate { get; set; }

        public int? TaxPayer { get; set; }

        [Column(TypeName = "bit")]
        public bool? Remitted { get; set; }

        public DateTime? DateRemitted { get; set; }

        [StringLength(45)]
        public string AssessmentType { get; set; }

        [StringLength(38)]
        public string State { get; set; }

        [StringLength(38)]
        public string LGA { get; set; }

        [StringLength(38)]
        public string AssessmentItem { get; set; }

        public decimal? Amount { get; set; }

        public int? Asset { get; set; }

        public virtual asset asset1 { get; set; }

        public virtual mda mda { get; set; }

        public virtual igr igr { get; set; }

        public virtual taxpayer taxpayer1 { get; set; }
    }
}
