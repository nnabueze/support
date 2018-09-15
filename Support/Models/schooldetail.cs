namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.schooldetails")]
    public partial class schooldetail
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string AdmissionNo { get; set; }

        [Required]
        [StringLength(255)]
        public string StudentName { get; set; }

        [StringLength(255)]
        public string Class { get; set; }

        [StringLength(255)]
        public string Term { get; set; }

        [StringLength(255)]
        public string Session { get; set; }

        [StringLength(255)]
        public string D_B { get; set; }

        public decimal? SchoolFees { get; set; }

        [StringLength(200)]
        public string Rebait { get; set; }

        [StringLength(255)]
        public string remark { get; set; }

        [StringLength(200)]
        public string BillerId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Created_At { get; set; }

        [StringLength(225)]
        public string uploadId { get; set; }
    }
}
