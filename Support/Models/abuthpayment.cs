namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.abuthpayments")]
    public partial class abuthpayment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(55)]
        public string TransId { get; set; }

        [Required]
        [StringLength(55)]
        public string PosId { get; set; }

        [Required]
        [StringLength(255)]
        public string PatientName { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(20)]
        public string Email { get; set; }

        [Required]
        [StringLength(55)]
        public string UserId { get; set; }

        public decimal TotalAmount { get; set; }

        public DateTime TransDate { get; set; }

        public bool IsRemitted { get; set; }

        [StringLength(55)]
        public string RemittanceId { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Create_At { get; set; }

        [Required]
        [StringLength(45)]
        public string ItemId { get; set; }

        [StringLength(255)]
        public string offlineTransId { get; set; }
    }
}
