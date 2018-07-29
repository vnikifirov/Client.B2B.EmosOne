namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            ItemAssignments = new HashSet<ItemAssignment>();
            ItemCheckInOuts = new HashSet<ItemCheckInOut>();
            ItemImages = new HashSet<ItemImage>();
            ItemLocations = new HashSet<ItemLocation>();
            ItemLocationLogs = new HashSet<ItemLocationLog>();
            ItemRequests = new HashSet<ItemRequest>();
            ItemSets = new HashSet<ItemSet>();
            ItemSets1 = new HashSet<ItemSet>();
            ItemUniqueProperties = new HashSet<ItemUniqueProperty>();
            JobItemAssignments = new HashSet<JobItemAssignment>();
            ItemDistributionTypes = new HashSet<ItemDistributionType>();
            OrganizationUnits = new HashSet<OrganizationUnit>();
            OrganizationUnitTypes = new HashSet<OrganizationUnitType>();
            UniformTypes = new HashSet<UniformType>();
            VolunteerJobs = new HashSet<VolunteerJob>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? VendorID { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [StringLength(50)]
        public string VendorProductCode { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }

        [StringLength(50)]
        public string BarCodeLable { get; set; }

        public int ItemTypeID { get; set; }

        public int? SizeTypeID { get; set; }

        public bool? Active { get; set; }

        public int? UnitID { get; set; }

        public int? UnitPackageID { get; set; }

        public int? UnitVolumeID { get; set; }

        public int TrackItemTypeID { get; set; }

        public virtual ItemType ItemType { get; set; }

        public virtual SizeType SizeType { get; set; }

        public virtual UnitOfMeasure UnitOfMeasure { get; set; }

        public virtual UnitOfMeasurePackageCount UnitOfMeasurePackageCount { get; set; }

        public virtual UnitOfMeasurePackageVolume UnitOfMeasurePackageVolume { get; set; }

        public virtual ItemVendor ItemVendor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemAssignment> ItemAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCheckInOut> ItemCheckInOuts { get; set; }

        public virtual ItemExtSignage ItemExtSignage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemImage> ItemImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocation> ItemLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocationLog> ItemLocationLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRequest> ItemRequests { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemSet> ItemSets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemSet> ItemSets1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemUniqueProperty> ItemUniqueProperties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobItemAssignment> JobItemAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemDistributionType> ItemDistributionTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnitType> OrganizationUnitTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UniformType> UniformTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerJob> VolunteerJobs { get; set; }
    }
}
