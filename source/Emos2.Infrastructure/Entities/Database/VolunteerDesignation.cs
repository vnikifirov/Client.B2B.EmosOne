namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerDesignation")]
    public partial class VolunteerDesignation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VolunteerDesignation()
        {
            VolunteerDesignation1 = new HashSet<VolunteerDesignation>();
            CEMUsers = new HashSet<CEMUser>();
            SkillCertifications = new HashSet<SkillCertification>();
            VolunteerJobs = new HashSet<VolunteerJob>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int EventID { get; set; }

        public bool Active { get; set; }

        public int? ParentID { get; set; }

        public bool ProfilePictureRequired { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerDesignation> VolunteerDesignation1 { get; set; }

        public virtual VolunteerDesignation VolunteerDesignation2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CEMUser> CEMUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkillCertification> SkillCertifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJob> VolunteerJobs { get; set; }
    }
}
