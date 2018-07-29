namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerJob")]
    public partial class VolunteerJob
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VolunteerJob()
        {
            EmailTemplateOrganizationalUnits = new HashSet<EmailTemplateOrganizationalUnit>();
            UserVolunteerJobs = new HashSet<UserVolunteerJob>();
            VolunteerJobShifts = new HashSet<VolunteerJobShift>();
            VolunteerDesignations = new HashSet<VolunteerDesignation>();
            SkillCertifications = new HashSet<SkillCertification>();
            Items = new HashSet<Item>();
        }

        public int ID { get; set; }

        public int EventID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public int OrganizationUnitID { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime? ActiveFrom { get; set; }

        public DateTime? ActiveTo { get; set; }

        public bool Active { get; set; }

        [Column(TypeName = "ntext")]
        public string SOW { get; set; }

        public int Priority { get; set; }

        [StringLength(50)]
        public string PrivateAccessCode { get; set; }

        public string WarningText { get; set; }

        public int? InOut { get; set; }

        public int? MinAge { get; set; }

        public int? MaxAge { get; set; }

        public bool? KidFriendly { get; set; }

        public int? AllowedOverlap { get; set; }

        public int? CheckInLocationID { get; set; }

        [Column(TypeName = "ntext")]
        public string ConfirmationEmailText { get; set; }

        public int? MinCertificatesNeeded { get; set; }

        [StringLength(4000)]
        public string WhereToGo { get; set; }

        [StringLength(20)]
        public string Longitude { get; set; }

        [StringLength(20)]
        public string Latitude { get; set; }

        public int? JobGroupID { get; set; }

        public virtual CheckInLocation CheckInLocation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailTemplateOrganizationalUnit> EmailTemplateOrganizationalUnits { get; set; }

        public virtual Event Event { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserVolunteerJob> UserVolunteerJobs { get; set; }

        public virtual VolunteerJobGroup VolunteerJobGroup { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJobShift> VolunteerJobShifts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerDesignation> VolunteerDesignations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkillCertification> SkillCertifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}
