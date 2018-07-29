namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemLocationLog")]
    public partial class ItemLocationLog
    {
        public int ID { get; set; }

        public int ItemID { get; set; }

        public int? LocationFromID { get; set; }

        public int? LocationToID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Quantity { get; set; }

        public int? SizeID { get; set; }

        public int? UniquePropertyID { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Item Item { get; set; }

        public virtual ItemUniqueProperty ItemUniqueProperty { get; set; }

        public virtual Location Location { get; set; }

        public virtual Location Location1 { get; set; }

        public virtual Size Size { get; set; }
    }
}
