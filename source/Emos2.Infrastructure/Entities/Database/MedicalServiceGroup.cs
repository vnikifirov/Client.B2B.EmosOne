namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicalServiceGroup")]
    public partial class MedicalServiceGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MedicalServiceGroup()
        {
            MedicalServiceGroup1 = new HashSet<MedicalServiceGroup>();
            MedicalServiceVolunteers = new HashSet<MedicalServiceVolunteer>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string TextColor { get; set; }

        [StringLength(10)]
        public string BackgroundColor { get; set; }

        public int? ParentID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalServiceGroup> MedicalServiceGroup1 { get; set; }

        public virtual MedicalServiceGroup MedicalServiceGroup2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalServiceVolunteer> MedicalServiceVolunteers { get; set; }
    }
}
