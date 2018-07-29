namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserVehicleOnEventDay")]
    public partial class UserVehicleOnEventDay
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        [StringLength(50)]
        public string LicensePlateNumber { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        [StringLength(50)]
        public string Make { get; set; }

        [StringLength(10)]
        public string PlateState { get; set; }

        [StringLength(50)]
        public string DriverName { get; set; }

        [StringLength(50)]
        public string DriverPhoneNumber { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
