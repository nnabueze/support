namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.fundsweeps")]
    public partial class fundsweep
    {
        public int Id { get; set; }

        [StringLength(45)]
        public string Coll { get; set; }

        [StringLength(45)]
        public string SerialNo { get; set; }

        [StringLength(45)]
        public string AccountNo { get; set; }

        [StringLength(45)]
        public string SortCode { get; set; }

        public decimal? Amount { get; set; }

        public DateTime? TxnDate { get; set; }

        [StringLength(45)]
        public string Payee { get; set; }

        [StringLength(45)]
        public string Payer { get; set; }

        [StringLength(45)]
        public string Narration { get; set; }

        [StringLength(45)]
        public string Reason { get; set; }

        public decimal? AmountCollected { get; set; }

        public decimal? AmountRemitted { get; set; }

        public decimal? AgencyAmount { get; set; }

        [StringLength(45)]
        public string Agency { get; set; }

        [StringLength(45)]
        public string Status { get; set; }

        [StringLength(45)]
        public string UploadId { get; set; }

        [StringLength(45)]
        public string BillerID { get; set; }

        [StringLength(45)]
        public string CreatedBy { get; set; }

        public DateTime? RemittedAt { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
