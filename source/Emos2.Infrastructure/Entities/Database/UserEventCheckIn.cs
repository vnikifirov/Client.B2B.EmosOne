namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserEventCheckIn")]
    public partial class UserEventCheckIn
    {
        public int ID { get; set; }

        public int EventID { get; set; }

        public int UserID { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime? CheckOut { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public int? CheckInLocationID { get; set; }

        public int? JobTypeID { get; set; }

        public int? CheckOutLocationID { get; set; }

        public int? CheckedBy { get; set; }

        [StringLength(50)]
        public string Lng { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        public int? SourceDevice { get; set; }

        [StringLength(100)]
        public string DeviceID { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CEMUser CEMUser1 { get; set; }
    }
}
