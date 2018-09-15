namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.rssh_upload")]
    public partial class rssh_upload
    {
        public int ID { get; set; }

        [StringLength(45)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Teller { get; set; }

        [StringLength(20)]
        public string InvoiceDate { get; set; }

        [StringLength(100)]
        public string Department { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? Quantity { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(100)]
        public string UploadedBy { get; set; }

        public DateTime? DateUploaded { get; set; }

        [StringLength(40)]
        public string UploadID { get; set; }
    }
}
