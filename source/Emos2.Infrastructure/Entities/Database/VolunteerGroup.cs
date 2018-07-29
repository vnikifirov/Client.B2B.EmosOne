namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerGroup")]
    public partial class VolunteerGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VolunteerGroup()
        {
            EmailTemplateOrganizationalUnits = new HashSet<EmailTemplateOrganizationalUnit>();
            VolunteerGroupAssignments = new HashSet<VolunteerGroupAssignment>();
            CEMUsers = new HashSet<CEMUser>();
        }

        public int ID { get; set; }

        public int EventID { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? ApprovedOn { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public bool Active { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CEMUser CEMUser1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailTemplateOrganizationalUnit> EmailTemplateOrganizationalUnits { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerGroupAssignment> VolunteerGroupAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CEMUser> CEMUsers { get; set; }
    }
}
