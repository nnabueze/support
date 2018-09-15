namespace Support.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("igr_collections.colortabs")]
    public partial class colortab
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(45)]
        public string ColourName { get; set; }

        [StringLength(45)]
        public string Colour { get; set; }

        [StringLength(45)]
        public string AscentColour { get; set; }
    }
}
