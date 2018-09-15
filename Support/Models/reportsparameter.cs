namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.reportsparameter")]
    public partial class reportsparameter
    {
        [Key]
        public int ReportParameterID { get; set; }

        [Required]
        [StringLength(38)]
        public string ReportID { get; set; }

        [StringLength(50)]
        public string ReportParameterName { get; set; }

        [StringLength(200)]
        public string DefaultValue { get; set; }

        [Column(TypeName = "bit")]
        public bool? ShowParameter { get; set; }

        public virtual reportslisting reportslisting { get; set; }
    }
}
