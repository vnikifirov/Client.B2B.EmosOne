namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemExtSignage")]
    public partial class ItemExtSignage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        [StringLength(50)]
        public string InventoryNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string SignReference { get; set; }

        [Required]
        [StringLength(100)]
        public string Material { get; set; }

        [StringLength(50)]
        public string SignColor { get; set; }

        [StringLength(50)]
        public string CopyLogoColor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Width { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Height { get; set; }

        [StringLength(50)]
        public string Sides { get; set; }

        [StringLength(50)]
        public string ExactCopyLogo { get; set; }

        [StringLength(50)]
        public string Finishing { get; set; }

        public virtual Item Item { get; set; }
    }
}
