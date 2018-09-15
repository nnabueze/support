namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.igr_users")]
    public partial class igr_users
    {
        [Key]
        [Column(Order = 0)]
        public string id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string Username { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        public DateTime? DateCreated { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(1073741823)]
        public string PhoneNumber { get; set; }

        [StringLength(1073741823)]
        public string PIN { get; set; }

        [StringLength(256)]
        public string Role { get; set; }

        [StringLength(100)]
        public string Priviledges { get; set; }

        [StringLength(128)]
        public string RoleId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(38)]
        public string IGRCode { get; set; }

        [StringLength(200)]
        public string IGR_Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(38)]
        public string MDACode { get; set; }

        [StringLength(100)]
        public string MDA_Name { get; set; }

        [StringLength(100)]
        public string MDAStation_Name { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CollectionLimit { get; set; }
    }
}
