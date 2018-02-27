namespace Assignment_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class plane
    {
        [Key]
        [Column("Fighter Planes", Order = 0)]
        [StringLength(50)]
        public string Fighter_Planes { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Models { get; set; }

        [Key]
        [Column("Manufacturing Year", Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Manufacturing_Year { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Company { get; set; }
    }
}
