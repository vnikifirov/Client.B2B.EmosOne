namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Airport")]
    public partial class Airport
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(150)]
        public string City { get; set; }
    }
}
