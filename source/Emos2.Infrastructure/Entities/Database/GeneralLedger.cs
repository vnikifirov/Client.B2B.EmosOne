namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GeneralLedger")]
    public partial class GeneralLedger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GeneralLedger()
        {
            VehicleTypes = new HashSet<VehicleType>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Number { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleType> VehicleTypes { get; set; }
    }
}
