namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleType")]
    public partial class VehicleType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleType()
        {
            Vehicles = new HashSet<Vehicle>();
            VehicleTypeRequests = new HashSet<VehicleTypeRequest>();
            SkillCertifications = new HashSet<SkillCertification>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public int? CategoryID { get; set; }

        public int? GLID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public int EventID { get; set; }

        [StringLength(100)]
        public string ImageName { get; set; }

        public virtual Event Event { get; set; }

        public virtual GeneralLedger GeneralLedger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicles { get; set; }

        public virtual VehicleCategory VehicleCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleTypeRequest> VehicleTypeRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SkillCertification> SkillCertifications { get; set; }
    }
}
