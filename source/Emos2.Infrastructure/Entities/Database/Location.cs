namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Location")]
    public partial class Location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location()
        {
            ItemCheckInOuts = new HashSet<ItemCheckInOut>();
            ItemLocations = new HashSet<ItemLocation>();
            ItemLocationLogs = new HashSet<ItemLocationLog>();
            ItemLocationLogs1 = new HashSet<ItemLocationLog>();
            Location1 = new HashSet<Location>();
            LocationAssignments = new HashSet<LocationAssignment>();
            VehiclePackListItems = new HashSet<VehiclePackListItem>();
        }

        public int ID { get; set; }

        public int? ParentID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string ContactPhone { get; set; }

        public int? BuildingID { get; set; }

        public int? AisleID { get; set; }

        public int? ShelfID { get; set; }

        public int? BinID { get; set; }

        [StringLength(250)]
        public string ImageName { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }

        [StringLength(50)]
        public string BarCodeLable { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        public string Note { get; set; }

        public bool? IsFull { get; set; }

        [StringLength(10)]
        public string TextColor { get; set; }

        [StringLength(10)]
        public string BackgroundColor { get; set; }

        public int? TypeID { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? CreatedBy { get; set; }

        public virtual Building Building { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCheckInOut> ItemCheckInOuts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocation> ItemLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocationLog> ItemLocationLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocationLog> ItemLocationLogs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location> Location1 { get; set; }

        public virtual Location Location2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LocationAssignment> LocationAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehiclePackListItem> VehiclePackListItems { get; set; }
    }
}
