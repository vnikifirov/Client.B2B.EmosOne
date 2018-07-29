namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleLocationHistory")]
    public partial class VehicleLocationHistory
    {
        public int ID { get; set; }

        public int VehicleID { get; set; }

        public int LocationID { get; set; }

        public DateTime? SetOn { get; set; }

        public int? SetBy { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public virtual VehicleLocation VehicleLocation { get; set; }
    }
}
