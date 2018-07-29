namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Meeting")]
    public partial class Meeting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meeting()
        {
            UserMeetings = new HashSet<UserMeeting>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string EventID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime MeetingStart { get; set; }

        public DateTime MeetingEnd { get; set; }

        public DateTime StartRegistration { get; set; }

        public DateTime? EndRegistration { get; set; }

        [StringLength(250)]
        public string Location { get; set; }

        public int? InvatationEmail { get; set; }

        public int? ThankYouEmail { get; set; }

        public int? ReminderEmail { get; set; }

        [StringLength(50)]
        public string Lng { get; set; }

        [StringLength(10)]
        public string AddToTimeline { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMeeting> UserMeetings { get; set; }
    }
}
