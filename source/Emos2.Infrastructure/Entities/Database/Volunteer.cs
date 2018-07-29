namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Volunteer")]
    public partial class Volunteer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Volunteer()
        {
            SurveyDistributions = new HashSet<SurveyDistribution>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MobilePhone { get; set; }

        [StringLength(255)]
        public string EmergencyContactPhone { get; set; }

        public bool? active { get; set; }

        [StringLength(50)]
        public string EmergencyContactFirstName { get; set; }

        [StringLength(50)]
        public string EmergencyContactLastName { get; set; }

        [StringLength(250)]
        public string StreetAddress { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string State { get; set; }

        [StringLength(10)]
        public string Zip { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        public DateTime? DOB { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        [StringLength(250)]
        public string ParentGuardian { get; set; }

        public DateTime? TextOptIn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SurveyDistribution> SurveyDistributions { get; set; }
    }
}
