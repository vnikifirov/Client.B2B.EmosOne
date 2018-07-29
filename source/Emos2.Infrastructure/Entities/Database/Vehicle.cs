namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehicle")]
    public partial class Vehicle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehicle()
        {
            VehicleCEMUsers = new HashSet<VehicleCEMUser>();
            VehicleLocationHistories = new HashSet<VehicleLocationHistory>();
            VehiclePackLists = new HashSet<VehiclePackList>();
            VehicleProperties = new HashSet<VehicleProperty>();
            VehicleTypeRequests = new HashSet<VehicleTypeRequest>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string LicencePlate { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }

        [StringLength(50)]
        public string BarCodeLable { get; set; }

        [StringLength(250)]
        public string ImageName { get; set; }

        public int? UseListID { get; set; }

        public int? GroupID { get; set; }

        public int? RentalCompanyID { get; set; }

        public int? TypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Number { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string DeliveryLocation { get; set; }

        public int? StickerTypeID { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        public int StatusID { get; set; }

        public int EventID { get; set; }

        [StringLength(10)]
        public string LicencePlateState { get; set; }

        [StringLength(100)]
        public string InternalNumber { get; set; }

        [StringLength(50)]
        public string Make { get; set; }

        [StringLength(50)]
        public string Model { get; set; }

        public DateTime? ExpectedArrivalTime { get; set; }

        public DateTime? ArrivalTime { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleCEMUser> VehicleCEMUsers { get; set; }

        public virtual VehicleGroup VehicleGroup { get; set; }

        public virtual VehicleRentalCompany VehicleRentalCompany { get; set; }

        public virtual VehicleStickerType VehicleStickerType { get; set; }

        public virtual VehicleType VehicleType { get; set; }

        public virtual VehicleUseList VehicleUseList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleLocationHistory> VehicleLocationHistories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehiclePackList> VehiclePackLists { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleProperty> VehicleProperties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleTypeRequest> VehicleTypeRequests { get; set; }
    }
}
