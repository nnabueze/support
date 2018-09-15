namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.powers")]
    public partial class power
    {
        public int Id { get; set; }

        [StringLength(1073741823)]
        public string SourceBankCode { get; set; }

        [StringLength(1073741823)]
        public string SourceBankName { get; set; }

        [StringLength(1073741823)]
        public string InstitutionCode { get; set; }

        public int ChannelCode { get; set; }

        public int Step { get; set; }

        [StringLength(1073741823)]
        public string CustomerName { get; set; }

        [StringLength(1073741823)]
        public string CustomerAccountNumber { get; set; }

        [StringLength(1073741823)]
        public string BillerID { get; set; }

        [StringLength(1073741823)]
        public string BillerName { get; set; }

        [StringLength(1073741823)]
        public string ProductID { get; set; }

        [StringLength(1073741823)]
        public string ProductName { get; set; }

        [StringLength(1073741823)]
        public string Amount { get; set; }

        [StringLength(1073741823)]
        public string phoneNumber { get; set; }

        [StringLength(1073741823)]
        public string email { get; set; }
    }
}
