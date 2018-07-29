namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehicleTypeRequest")]
    public partial class VehicleTypeRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehicleTypeRequest()
        {
            VehicleTypeRequestStatus = new HashSet<VehicleTypeRequestStatu>();
        }

        public int ID { get; set; }

        public int TypeID { get; set; }

        public int UserID { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int? BUID { get; set; }

        [StringLength(150)]
        public string Driver { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public int? VendorID { get; set; }

        public int? ConfirmedVehicleID { get; set; }

        public int? BUID2 { get; set; }

        [StringLength(150)]
        public string Driver2 { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; }

        public virtual BusinessUnit BusinessUnit1 { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public virtual VehicleType VehicleType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleTypeRequestStatu> VehicleTypeRequestStatus { get; set; }
    }
}
