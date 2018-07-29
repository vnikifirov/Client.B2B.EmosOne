namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemImage")]
    public partial class ItemImage
    {
        public int ID { get; set; }

        public int ItemID { get; set; }

        [Required]
        [StringLength(50)]
        public string Image { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public virtual Item Item { get; set; }
    }
}
