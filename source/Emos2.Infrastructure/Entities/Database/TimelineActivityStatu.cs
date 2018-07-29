namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TimelineActivityStatu
    {
        public int ID { get; set; }

        public int TimelineActivityID { get; set; }

        public int StatusID { get; set; }

        public DateTime StatusOn { get; set; }

        public int? StatusBy { get; set; }

        [StringLength(50)]
        public string StatusLat { get; set; }

        [StringLength(50)]
        public string StatusLng { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual TimelineActivity TimelineActivity { get; set; }
    }
}
