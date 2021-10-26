namespace DVH1621050875.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class Base
    {
        [Key]
        [StringLength(20)]
        public string PersonId { get; set; }

        [Required]
        [StringLength(50)]
        public string PersonName { get; set; }
    }
}
