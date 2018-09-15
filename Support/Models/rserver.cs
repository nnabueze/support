namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.rservers")]
    public partial class rserver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rserver()
        {
            reportslistings = new HashSet<reportslisting>();
        }

        [Key]
        [StringLength(38)]
        public string Rserver_ID { get; set; }

        [StringLength(45)]
        public string RServerName { get; set; }

        [StringLength(45)]
        public string RServerPwd { get; set; }

        [StringLength(45)]
        public string RserverDomain { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reportslisting> reportslistings { get; set; }
    }
}
