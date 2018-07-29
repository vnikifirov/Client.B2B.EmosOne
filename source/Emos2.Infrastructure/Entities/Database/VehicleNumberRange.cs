namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleNumberRange")]
    public partial class VehicleNumberRange
    {
        public int ID { get; set; }

        public int GroupId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int RangeFrom { get; set; }

        public int RangeTo { get; set; }

        public virtual VehicleNumberRangeGroup VehicleNumberRangeGroup { get; set; }
    }
}
