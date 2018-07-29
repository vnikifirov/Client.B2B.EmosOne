namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VehiclePackList")]
    public partial class VehiclePackList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VehiclePackList()
        {
            VehiclePackListItems = new HashSet<VehiclePackListItem>();
        }

        public int ID { get; set; }

        public int? VehicleID { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string CellPhone { get; set; }

        public DateTime PackedOn { get; set; }

        public DateTime? UnpackedOn { get; set; }

        [StringLength(100)]
        public string LoadingLocation { get; set; }

        [StringLength(100)]
        public string DestinationLocation { get; set; }

        public int AuthorizedBy { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        public int? DriverID { get; set; }

        public int? LoadingLocationID { get; set; }

        public int? DestinationLocationID { get; set; }

        public int? PackedBy { get; set; }

        public int TypeID { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehiclePackListItem> VehiclePackListItems { get; set; }
    }
}
