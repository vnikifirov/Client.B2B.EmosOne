namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleLocation")]
    public partial class VehicleLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleLocation()
        {
            VehicleLocationHistories = new HashSet<VehicleLocationHistory>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public string Descripton { get; set; }

        [Required]
        [StringLength(50)]
        public string Lng { get; set; }

        [Required]
        [StringLength(50)]
        public string Lat { get; set; }

        public bool? Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleLocationHistory> VehicleLocationHistories { get; set; }
    }
}
