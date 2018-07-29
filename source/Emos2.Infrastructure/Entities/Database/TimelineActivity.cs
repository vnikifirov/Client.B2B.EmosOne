namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimelineActivity")]
    public partial class TimelineActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimelineActivity()
        {
            TimelineActivityStatus = new HashSet<TimelineActivityStatu>();
            OrganizationUnits = new HashSet<OrganizationUnit>();
            CEMUsers = new HashSet<CEMUser>();
        }

        public int ID { get; set; }

        public int EventID { get; set; }

        [Required]
        [StringLength(350)]
        public string Activity { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime DueDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public int? TimeSensitivity { get; set; }

        public int? SendAlert { get; set; }

        public int TypeID { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int LastStatusId { get; set; }

        public int? StatusBy { get; set; }

        public int? Reminder { get; set; }

        public DateTime? ReminderSentOn { get; set; }

        public int? ReminderSendTypeID { get; set; }

        public int? ReminderSendTo { get; set; }

        public int? AlertSendTo { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimelineActivityStatu> TimelineActivityStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CEMUser> CEMUsers { get; set; }
    }
}
