namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.richfields")]
    public partial class richfield
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string SessionID { get; set; }

        [StringLength(255)]
        public string Surname { get; set; }

        [StringLength(255)]
        public string Firstname { get; set; }

        [StringLength(255)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string VehicleNumber { get; set; }

        [StringLength(255)]
        public string VehicleType { get; set; }

        [StringLength(255)]
        public string ProductType { get; set; }

        [StringLength(255)]
        public string amount { get; set; }

        [StringLength(255)]
        public string state { get; set; }

        [StringLength(255)]
        public string DestinationBankCode { get; set; }

        [StringLength(255)]
        public string SourceBankName { get; set; }

        [StringLength(255)]
        public string TransactionDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime create_at { get; set; }
    }
}
