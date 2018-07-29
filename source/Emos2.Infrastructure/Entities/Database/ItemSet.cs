namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemSet")]
    public partial class ItemSet
    {
        public int ID { get; set; }

        public int ItemID { get; set; }

        public int? ParentID { get; set; }

        public int Quantity { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public bool Active { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CEMUser CEMUser1 { get; set; }

        public virtual Item Item { get; set; }

        public virtual Item Item1 { get; set; }
    }
}
