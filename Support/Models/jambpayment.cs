namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.jambpayments")]
    public partial class jambpayment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string SessionID { get; set; }

        [StringLength(255)]
        public string Amount { get; set; }

        [StringLength(255)]
        public string Surname { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(255)]
        public string GSMNo { get; set; }

        [Required]
        [StringLength(255)]
        public string token { get; set; }

        [StringLength(255)]
        public string Pin { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime date { get; set; }
    }
}
