namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.schoolnotifications")]
    public partial class schoolnotification
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string SessionId { get; set; }

        [StringLength(255)]
        public string BillerId { get; set; }

        [StringLength(255)]
        public string SourceBank { get; set; }

        [StringLength(255)]
        public string DestinationBank { get; set; }

        [StringLength(255)]
        public string PayerName { get; set; }

        [StringLength(255)]
        public string PayerPhone { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string StudentName { get; set; }

        [StringLength(255)]
        public string AdmissionNo { get; set; }

        [StringLength(255)]
        public string Class { get; set; }

        [StringLength(255)]
        public string Term { get; set; }

        [StringLength(255)]
        public string Session { get; set; }

        public DateTime? ApprovedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? Created_At { get; set; }
    }
}
