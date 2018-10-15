namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.schoolclasses")]
    public partial class schoolclass
    {
        public int Id { get; set; }

        [Key]
        [Required]
        [StringLength(255)]
        public string ClassId { get; set; }

        [Required]
        [StringLength(255)]
        public string IGR_Code { get; set; }

        [Required]
        [StringLength(255)]
        public string ClassName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        public decimal SchoolFees { get; set; }

        public virtual ICollection<student_information> studentInformation { get; set; }
    }
}
