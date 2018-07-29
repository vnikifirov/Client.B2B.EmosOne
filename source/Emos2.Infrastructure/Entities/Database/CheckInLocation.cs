namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CheckInLocation")]
    public partial class CheckInLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CheckInLocation()
        {
            Jobs = new HashSet<Job>();
            ParticipantCheckIns = new HashSet<ParticipantCheckIn>();
            VolunteerEventCheckIns = new HashSet<VolunteerEventCheckIn>();
            VolunteerJobs = new HashSet<VolunteerJob>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        public TimeSpan? OpenHours { get; set; }

        public TimeSpan? CloseHours { get; set; }

        public TimeSpan? CheckOutBeforeTime { get; set; }

        public int? TypeID { get; set; }

        public bool Active { get; set; }

        [StringLength(50)]
        public string Lng { get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        public bool NeedToBeOnSiteToCheckIn { get; set; }

        public int DistanceFromCheckIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipantCheckIn> ParticipantCheckIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerEventCheckIn> VolunteerEventCheckIns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJob> VolunteerJobs { get; set; }
    }
}
