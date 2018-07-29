namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileDevice")]
    public partial class MobileDevice
    {
        public int ID { get; set; }

        [Required]
        public string DeviceID { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public bool Active { get; set; }

        public int EventID { get; set; }

        public int? UserID { get; set; }
    }
}
