namespace DVH1621050875.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student : Base
    {

        [Required]
        [StringLength(50)]
        public string University { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }
    }
}
