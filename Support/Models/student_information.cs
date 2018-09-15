namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.student_information")]
    public partial class student_information
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string IGR_Code { get; set; }

        [Required]
        [StringLength(255)]
        public string AdmissionNo { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        public string ClassId { get; set; }

        [Required]
        [StringLength(255)]
        public string TermId { get; set; }

        [Required]
        [StringLength(255)]
        public string SessionId { get; set; }

        [StringLength(255)]
        public string StudentType { get; set; }

        [StringLength(255)]
        public string Rebate { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }

        [StringLength(255)]
        public string Gender { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? created_at { get; set; }

        [StringLength(45)]
        public string uploadId { get; set; }
    }
}
