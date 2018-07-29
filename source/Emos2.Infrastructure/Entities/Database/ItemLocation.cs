namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemLocation")]
    public partial class ItemLocation
    {
        public int ID { get; set; }

        public int ItemID { get; set; }

        public int LocationID { get; set; }

        public DateTime UpdatedOn { get; set; }

        public int Quantity { get; set; }

        public int? SizeID { get; set; }

        public int? UniquePropertyID { get; set; }

        public virtual Item Item { get; set; }

        public virtual ItemUniqueProperty ItemUniqueProperty { get; set; }

        public virtual Location Location { get; set; }

        public virtual Size Size { get; set; }
    }
}
