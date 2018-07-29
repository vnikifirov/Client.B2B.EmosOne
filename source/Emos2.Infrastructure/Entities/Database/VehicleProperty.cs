namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleProperty")]
    public partial class VehicleProperty
    {
        public int id { get; set; }

        public int VehicleID { get; set; }

        public int PropertyID { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        [Required]
        [StringLength(50)]
        public string Value { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
