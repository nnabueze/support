namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.kingscares")]
    public partial class kingscare
    {
        [Column(TypeName = "uint")]
        public long Id { get; set; }

        [StringLength(255)]
        public string SessionID { get; set; }

        [StringLength(30)]
        public string TransactionDate { get; set; }

        [StringLength(255)]
        public string SourceBankName { get; set; }

        [StringLength(30)]
        public string DestinationBankCode { get; set; }

        [StringLength(255)]
        public string PupilsName { get; set; }

        [StringLength(100)]
        public string Class { get; set; }

        [StringLength(100)]
        public string Term { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(255)]
        public string PayersName { get; set; }

        [StringLength(255)]
        public string PhoneNumber { get; set; }

        [StringLength(100)]
        public string Duration { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
    }
}
