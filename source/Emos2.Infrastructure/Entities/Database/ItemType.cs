namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemType")]
    public partial class ItemType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemType()
        {
            Items = new HashSet<Item>();
            ItemType1 = new HashSet<ItemType>();
            OrganizationUnits = new HashSet<OrganizationUnit>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Descripton { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RequestStarts { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RequestDeadline { get; set; }

        public bool? Active { get; set; }

        public int? ParentID { get; set; }

        public int? PredefinedItemTypeID { get; set; }

        public int BaseTypeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemType> ItemType1 { get; set; }

        public virtual ItemType ItemType2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; }
    }
}
