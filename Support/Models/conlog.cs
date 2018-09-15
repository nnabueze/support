namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.conlogs")]
    public partial class conlog
    {
        public int Id { get; set; }

        [StringLength(1073741823)]
        public string Content { get; set; }
    }
}
