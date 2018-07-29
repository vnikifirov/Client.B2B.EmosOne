namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleCEMUser")]
    public partial class VehicleCEMUser
    {
        public int ID { get; set; }

        public int VehicleID { get; set; }

        public int CEMUserID { get; set; }

        public int AuthorizedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AuthrizedOn { get; set; }

        public DateTime? CheckOutTime { get; set; }

        public DateTime? CheckInTime { get; set; }

        public int? StatusID { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public DateTime? CheckInTimeExpected { get; set; }

        public DateTime? ReserveFrom { get; set; }

        public DateTime? ReserveTo { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}
