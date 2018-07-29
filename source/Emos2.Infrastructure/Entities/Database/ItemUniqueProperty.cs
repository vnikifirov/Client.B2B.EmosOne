namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemUniqueProperty")]
    public partial class ItemUniqueProperty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemUniqueProperty()
        {
            ItemAssignments = new HashSet<ItemAssignment>();
            ItemCheckInOuts = new HashSet<ItemCheckInOut>();
            ItemLocations = new HashSet<ItemLocation>();
            ItemLocationLogs = new HashSet<ItemLocationLog>();
        }

        public int ID { get; set; }

        public int ItemID { get; set; }

        [Required]
        [StringLength(100)]
        public string UniqueProperty { get; set; }

        public bool Active { get; set; }

        public virtual Item Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemAssignment> ItemAssignments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemCheckInOut> ItemCheckInOuts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocation> ItemLocations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemLocationLog> ItemLocationLogs { get; set; }
    }
}
