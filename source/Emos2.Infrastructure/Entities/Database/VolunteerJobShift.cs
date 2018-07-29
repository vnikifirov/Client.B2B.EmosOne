namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerJobShift")]
    public partial class VolunteerJobShift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VolunteerJobShift()
        {
            EmailTemplateOrganizationalUnits = new HashSet<EmailTemplateOrganizationalUnit>();
            VolunteerEventCheckIns = new HashSet<VolunteerEventCheckIn>();
            VolunteerJobAssignments = new HashSet<VolunteerJobAssignment>();
            CEMUsers = new HashSet<CEMUser>();
        }

        public int ID { get; set; }

        public int VolunteerJobID { get; set; }

        public DateTime ShiftFrom { get; set; }

        public DateTime ShiftTo { get; set; }

        public int? PositionTotal { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        [StringLength(50)]
        public string PrivateAccessCode { get; set; }

        [StringLength(4000)]
        public string WhereToGo { get; set; }

        [StringLength(20)]
        public string Longitude { get; set; }

        [StringLength(20)]
        public string Latitude { get; set; }

        public DateTime? CheckInTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailTemplateOrganizationalUnit> EmailTemplateOrganizationalUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerEventCheckIn> VolunteerEventCheckIns { get; set; }

        public virtual VolunteerJob VolunteerJob { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJobAssignment> VolunteerJobAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CEMUser> CEMUsers { get; set; }
    }
}
