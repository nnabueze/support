namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.schoolsessions")]
    public partial class schoolsession
    {
        public int Id { get; set; }

        [Key]
        [Required]
        [StringLength(255)]
        public string SessionId { get; set; }

        [Required]
        [StringLength(255)]
        public string IGR_Code { get; set; }

        [Required]
        [StringLength(255)]
        public string SessionName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        public virtual ICollection<student_information> studentInformation { get; set; }
    }
}
