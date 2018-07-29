namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobItemAssignment")]
    public partial class JobItemAssignment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(200)]
        public string Note { get; set; }

        public virtual Item Item { get; set; }

        public virtual Job Job { get; set; }
    }
}
