namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemDistributionType")]
    public partial class ItemDistributionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemDistributionType()
        {
            ItemDistributionType1 = new HashSet<ItemDistributionType>();
            OrganizationUnits = new HashSet<OrganizationUnit>();
            Items = new HashSet<Item>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Descripton { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RequestStarts { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RequestDeadline { get; set; }

        public bool? Active { get; set; }

        public int? ParentID { get; set; }

        public int? EventID { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemDistributionType> ItemDistributionType1 { get; set; }

        public virtual ItemDistributionType ItemDistributionType2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}
