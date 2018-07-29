namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerEventCheckIn")]
    public partial class VolunteerEventCheckIn
    {
        public int ID { get; set; }

        public int VolunteerID { get; set; }

        public int EventID { get; set; }

        public int? ShiftID { get; set; }

        public DateTime CheckInTime { get; set; }

        public int CheckInLocationID { get; set; }

        public int? CheckedInBy { get; set; }

        [StringLength(50)]
        public string Lng { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        public int? SourceDevice { get; set; }

        [StringLength(100)]
        public string DeviceID { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CheckInLocation CheckInLocation { get; set; }

        public virtual Event Event { get; set; }

        public virtual VolunteerJobShift VolunteerJobShift { get; set; }
    }
}
