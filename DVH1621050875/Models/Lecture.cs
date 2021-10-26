namespace DVH1621050875.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lecture")]
    public partial class Lecture : Base
    {

        [Required]
        [StringLength(50)]
        public string Faculty { get; set; }

        [Required]
        [StringLength(50)]
        public string Department { get; set; }
    }
}
