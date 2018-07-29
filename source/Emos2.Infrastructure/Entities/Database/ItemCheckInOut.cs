namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemCheckInOut")]
    public partial class ItemCheckInOut
    {
        public int ID { get; set; }

        public int ItemID { get; set; }

        public int? SizeID { get; set; }

        public int? UniquePropertyID { get; set; }

        public int AuthorizedBy { get; set; }

        public int CheckBy { get; set; }

        public DateTime CheckDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CheckQuantity { get; set; }

        public int? CheckLocation { get; set; }

        [Column(TypeName = "text")]
        public string Note { get; set; }

        public int InOut { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? EventID { get; set; }

        public int? ItemAssignmentID { get; set; }

        public int? ParentID { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CEMUser CEMUser1 { get; set; }

        public virtual Event Event { get; set; }

        public virtual Item Item { get; set; }

        public virtual ItemUniqueProperty ItemUniqueProperty { get; set; }

        public virtual Location Location { get; set; }

        public virtual Size Size { get; set; }
    }
}
