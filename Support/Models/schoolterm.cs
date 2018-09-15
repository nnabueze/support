namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.schoolterms")]
    public partial class schoolterm
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string IGR_Code { get; set; }

        [Required]
        [StringLength(255)]
        public string TermId { get; set; }

        [Required]
        [StringLength(255)]
        public string Term { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }
    }
}
