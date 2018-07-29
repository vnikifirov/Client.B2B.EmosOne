namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemBackup")]
    public partial class ItemBackup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? VendorID { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public int? CategoryID { get; set; }

        public int? SubCategoryID { get; set; }

        [Column(TypeName = "ntext")]
        public string Notes { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        [StringLength(50)]
        public string VendorProductCode { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }

        [StringLength(50)]
        public string BarCodeLable { get; set; }

        public int ItemTypeID { get; set; }

        public int? SizeTypeID { get; set; }

        public bool? Active { get; set; }
    }
}
