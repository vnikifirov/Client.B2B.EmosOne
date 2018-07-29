namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParticipantCheckIn")]
    public partial class ParticipantCheckIn
    {
        public int ID { get; set; }

        [StringLength(15)]
        public string BIB { get; set; }

        public int CheckInLocationID { get; set; }

        public int EventID { get; set; }

        public int StatusID { get; set; }

        public DateTime StatusOn { get; set; }

        public int? StatusBy { get; set; }

        public string Note { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CheckInLocation CheckInLocation { get; set; }
    }
}
