namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicalLicense")]
    public partial class MedicalLicense
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalLicense()
        {
            VolunteerMedicalLicenses = new HashSet<VolunteerMedicalLicense>();
        }

        public int ID { get; set; }

        public bool? IsSameName { get; set; }

        [Required]
        [StringLength(50)]
        public string LicenseNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string IssuingState { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool? IsInGoodStanding { get; set; }

        public bool? IsFreeOfRestrictions { get; set; }

        public bool? Validated { get; set; }

        public DateTime? ValidatedOn { get; set; }

        public int? ValidatedBy { get; set; }

        public string Note { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerMedicalLicense> VolunteerMedicalLicenses { get; set; }
    }
}
