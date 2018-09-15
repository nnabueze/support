namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.enumerations")]
    public partial class enumeration
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Serial { get; set; }

        [StringLength(255)]
        public string Region { get; set; }

        [StringLength(255)]
        public string Enumerator { get; set; }

        [StringLength(255)]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        public string FeederName { get; set; }

        [StringLength(255)]
        public string TransformerName { get; set; }

        [StringLength(255)]
        public string TransfermerCode { get; set; }

        [StringLength(255)]
        public string PoleServiceWireRemark { get; set; }

        [StringLength(255)]
        public string PoleType { get; set; }

        [StringLength(255)]
        public string PoleCondition { get; set; }

        [StringLength(255)]
        public string WireType { get; set; }

        [StringLength(20)]
        public string WireCondition { get; set; }

        [StringLength(30)]
        public string PropertyType { get; set; }

        [StringLength(100)]
        public string AccountNumber { get; set; }

        [StringLength(200)]
        public string MeterTariff { get; set; }

        [StringLength(255)]
        public string CustomerName { get; set; }

        [StringLength(255)]
        public string CspName { get; set; }

        [StringLength(255)]
        public string MeterNumber { get; set; }

        [StringLength(255)]
        public string ServiceAddress { get; set; }

        [StringLength(20)]
        public string CustomerTitle { get; set; }

        [StringLength(255)]
        public string CustomerFirstName { get; set; }

        [StringLength(255)]
        public string CustomerLastName { get; set; }

        [StringLength(255)]
        public string HouseNumber { get; set; }

        [StringLength(255)]
        public string MobileNumber { get; set; }

        [StringLength(255)]
        public string Street { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(255)]
        public string LandMark { get; set; }

        [StringLength(255)]
        public string City { get; set; }

        [StringLength(255)]
        public string Village { get; set; }

        [StringLength(255)]
        public string CustomerStatus { get; set; }

        [StringLength(255)]
        public string FileMeterNumber { get; set; }

        [StringLength(255)]
        public string Lga { get; set; }

        [StringLength(255)]
        public string CustormerRemark { get; set; }

        [StringLength(255)]
        public string State { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        public double? Altitude { get; set; }

        [StringLength(255)]
        public string AccountStatus { get; set; }

        [StringLength(255)]
        public string BookCode { get; set; }

        [StringLength(255)]
        public string AmountBilled { get; set; }

        [StringLength(255)]
        public string MeterType { get; set; }

        [StringLength(255)]
        public string MeterModel { get; set; }

        [StringLength(255)]
        public string MeterStatus { get; set; }

        [StringLength(255)]
        public string MeterPhase { get; set; }

        [StringLength(255)]
        public string MeterRemark { get; set; }

        [StringLength(255)]
        public string Date { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime created_at { get; set; }

        [StringLength(45)]
        public string ImageId { get; set; }

        [StringLength(45)]
        public string UniqueID { get; set; }
    }
}
