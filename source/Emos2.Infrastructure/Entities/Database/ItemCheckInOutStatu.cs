namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemCheckInOutStatu
    {
        public long ID { get; set; }

        public int StatusBy { get; set; }

        public DateTime StatusOn { get; set; }

        [Required]
        [StringLength(200)]
        public string Note { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
