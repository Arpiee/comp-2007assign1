namespace Assignment_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class chopper
    {
        [Required]
        [StringLength(50)]
        public string Helicopters { get; set; }

        public int Models { get; set; }

        [Required]
        [StringLength(50)]
        public string Purpose { get; set; }

        [Key]
        [Column("Manufacturing Year")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Manufacturing_Year { get; set; }
    }
}
