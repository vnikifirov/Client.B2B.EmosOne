namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicalServiceVolunteer")]
    public partial class MedicalServiceVolunteer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalServiceVolunteer()
        {
            MedicalServiceGroups = new HashSet<MedicalServiceGroup>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string Job { get; set; }

        [StringLength(50)]
        public string Shift { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string CellPhone { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        [StringLength(100)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        public DateTime? Submitted { get; set; }

        [StringLength(100)]
        public string HospitalSchool { get; set; }

        [StringLength(100)]
        public string RNSpeciality { get; set; }

        [StringLength(100)]
        public string PhysicianSpeciality { get; set; }

        [StringLength(100)]
        public string MedFieldOfStudy { get; set; }

        [StringLength(255)]
        public string SchoolAffiliation { get; set; }

        [StringLength(50)]
        public string MedSchoolExpGrad { get; set; }

        [StringLength(10)]
        public string PreviousJobs { get; set; }

        [StringLength(50)]
        public string MedicalLicenseVerified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalServiceGroup> MedicalServiceGroups { get; set; }
    }
}
