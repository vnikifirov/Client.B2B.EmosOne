namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessUnit")]
    public partial class BusinessUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessUnit()
        {
            HotelRequests = new HashSet<HotelRequest>();
            VehicleTypeRequests = new HashSet<VehicleTypeRequest>();
            VehicleTypeRequests1 = new HashSet<VehicleTypeRequest>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HotelRequest> HotelRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleTypeRequest> VehicleTypeRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleTypeRequest> VehicleTypeRequests1 { get; set; }
    }
}
