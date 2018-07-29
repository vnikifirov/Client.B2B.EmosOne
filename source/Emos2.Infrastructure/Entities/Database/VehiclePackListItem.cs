namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehiclePackListItem")]
    public partial class VehiclePackListItem
    {
        public int ID { get; set; }

        public int VehiclePackListID { get; set; }

        [StringLength(255)]
        public string ItemName { get; set; }

        public int? Quantity { get; set; }

        public int? ContainerID { get; set; }

        public virtual Location Location { get; set; }

        public virtual VehiclePackList VehiclePackList { get; set; }
    }
}
