namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.isnotifications")]
    public partial class isnotification
    {
        public int Id { get; set; }

        [StringLength(1073741823)]
        public string ServiceUrl { get; set; }

        [StringLength(1073741823)]
        public string ServiceUsername { get; set; }

        [StringLength(1073741823)]
        public string ServicePassword { get; set; }

        [StringLength(1073741823)]
        public string FTPUrl { get; set; }

        [StringLength(1073741823)]
        public string FTPUsername { get; set; }

        [StringLength(1073741823)]
        public string FTPPassword { get; set; }

        public bool? IsRepeated { get; set; }

        [StringLength(1073741823)]
        public string ProductGroupCode { get; set; }

        [StringLength(1073741823)]
        public string PaymentLogId { get; set; }

        [StringLength(1073741823)]
        public string CustReference { get; set; }

        [StringLength(1073741823)]
        public string AlternateCustReference { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(1073741823)]
        public string PaymentStatus { get; set; }

        [StringLength(1073741823)]
        public string PaymentMethod { get; set; }

        [StringLength(1073741823)]
        public string PaymentReference { get; set; }

        [StringLength(1073741823)]
        public string TerminalId { get; set; }

        [StringLength(1073741823)]
        public string ChannelName { get; set; }

        [StringLength(1073741823)]
        public string Location { get; set; }

        public bool? IsReversal { get; set; }

        public DateTime? PaymentDate { get; set; }

        public DateTime? SettlementDate { get; set; }

        [StringLength(1073741823)]
        public string InstitutionId { get; set; }

        [StringLength(1073741823)]
        public string InstitutionName { get; set; }

        [StringLength(1073741823)]
        public string BranchName { get; set; }

        [StringLength(1073741823)]
        public string BankName { get; set; }

        [StringLength(1073741823)]
        public string FeeName { get; set; }

        [StringLength(1073741823)]
        public string CustomerName { get; set; }

        [StringLength(1073741823)]
        public string OtherCustomerInfo { get; set; }

        [StringLength(1073741823)]
        public string ReceiptNo { get; set; }

        [StringLength(1073741823)]
        public string CollectionsAccount { get; set; }

        [StringLength(1073741823)]
        public string ThirdPartyCode { get; set; }

        [StringLength(1073741823)]
        public string ItemName { get; set; }

        [StringLength(1073741823)]
        public string ItemCode { get; set; }

        public decimal? ItemAmount { get; set; }

        [StringLength(1073741823)]
        public string LeadBankCode { get; set; }

        [StringLength(1073741823)]
        public string LeadBankCbnCode { get; set; }

        [StringLength(1073741823)]
        public string LeadBankName { get; set; }

        [StringLength(1073741823)]
        public string CategoryCode { get; set; }

        [StringLength(1073741823)]
        public string CategoryName { get; set; }

        [StringLength(1073741823)]
        public string ItemQuantity { get; set; }

        [StringLength(1073741823)]
        public string BankCode { get; set; }

        [StringLength(1073741823)]
        public string CustomerAddress { get; set; }

        [StringLength(1073741823)]
        public string CustomerPhoneNumber { get; set; }

        [StringLength(1073741823)]
        public string DepositorName { get; set; }

        [StringLength(1073741823)]
        public string DepositorSlipNumber { get; set; }

        [StringLength(1073741823)]
        public string PaymentCurrency { get; set; }

        [StringLength(1073741823)]
        public string OriginalPaymentLogId { get; set; }

        [StringLength(1073741823)]
        public string OriginalPaymentReference { get; set; }

        [StringLength(1073741823)]
        public string Teller { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? IsSent { get; set; }
    }
}
