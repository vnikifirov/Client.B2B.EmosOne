namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerJobAssignment")]
    public partial class VolunteerJobAssignment
    {
        public int ID { get; set; }

        public int VolunteerID { get; set; }

        public DateTime? AppliedOn { get; set; }

        public int? RejectedBy { get; set; }

        public DateTime? RejectedOn { get; set; }

        public int? ConfirmedBy { get; set; }

        public DateTime? ConfirmedOn { get; set; }

        public int? StatusID { get; set; }

        public int? JobShiftID { get; set; }

        public DateTime? NotificationSentOn { get; set; }

        public int EventID { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CEMUser CEMUser1 { get; set; }

        public virtual CEMUser CEMUser2 { get; set; }

        public virtual Event Event { get; set; }

        public virtual VolunteerJobShift VolunteerJobShift { get; set; }
    }
}
