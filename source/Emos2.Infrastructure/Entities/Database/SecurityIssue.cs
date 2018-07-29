namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecurityIssue")]
    public partial class SecurityIssue
    {
        public int ID { get; set; }

        public int UserId { get; set; }

        public int EventId { get; set; }

        [Required]
        [StringLength(200)]
        public string Image { get; set; }

        public DateTime timestamp { get; set; }

        [Required]
        public string Note { get; set; }

        [Required]
        [StringLength(50)]
        public string Lng { get; set; }

        [Required]
        [StringLength(50)]
        public string Lat { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Event Event { get; set; }
    }
}
