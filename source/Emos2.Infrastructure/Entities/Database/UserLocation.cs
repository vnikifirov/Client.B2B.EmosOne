namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLocation")]
    public partial class UserLocation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Lng { get; set; }

        [Required]
        [StringLength(50)]
        public string Lat { get; set; }

        public DateTime Timestamp { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
