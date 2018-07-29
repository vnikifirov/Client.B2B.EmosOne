namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleGroup")]
    public partial class VehicleGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleGroup()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
