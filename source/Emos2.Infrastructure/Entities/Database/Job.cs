namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            AirfareRequests = new HashSet<AirfareRequest>();
            HotelRequests = new HashSet<HotelRequest>();
            JobItemAssignments = new HashSet<JobItemAssignment>();
            JobRadioChannels = new HashSet<JobRadioChannel>();
            JobShifts = new HashSet<JobShift>();
            UserJobs = new HashSet<UserJob>();
            OrganizationUnits = new HashSet<OrganizationUnit>();
            PermissionRoles = new HashSet<PermissionRole>();
            SecurityZones = new HashSet<SecurityZone>();
            SkillCertifications = new HashSet<SkillCertification>();
        }

        public int ID { get; set; }

        public int EventID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayRate { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string SOW { get; set; }

        public int? UniformType { get; set; }

        public int OrganizationUnitID { get; set; }

        public int SetUserLevel { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? ConfirmedBy { get; set; }

        public DateTime? ConfirmedOn { get; set; }

        public int? TypeID { get; set; }

        public int? BU { get; set; }

        public int? GL { get; set; }

        public int? CheckInLocationID { get; set; }

        public string RecapNotes { get; set; }

        public bool Active { get; set; }

        public string InternalComment { get; set; }

        public int? Meeting { get; set; }

        public int? AppreciationParty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirfareRequest> AirfareRequests { get; set; }

        public virtual CheckInLocation CheckInLocation { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelRequest> HotelRequests { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; }

        public virtual UniformType UniformType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobItemAssignment> JobItemAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobRadioChannel> JobRadioChannels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobShift> JobShifts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserJob> UserJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecurityZone> SecurityZones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkillCertification> SkillCertifications { get; set; }
    }
}
