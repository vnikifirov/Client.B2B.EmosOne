namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemRequest")]
    public partial class ItemRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ItemRequest()
        {
            ItemRequestStatus = new HashSet<ItemRequestStatu>();
        }

        public int ID { get; set; }

        public int ItemID { get; set; }

        public int RequestedBy { get; set; }

        public int? OrganizationUnitID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Quantity { get; set; }

        public int? SizeId { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string Note { get; set; }

        public int LastStatusId { get; set; }

        public int EventID { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Event Event { get; set; }

        public virtual Item Item { get; set; }

        public virtual OrganizationUnit OrganizationUnit { get; set; }

        public virtual Size Size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemRequestStatu> ItemRequestStatus { get; set; }
    }
}
