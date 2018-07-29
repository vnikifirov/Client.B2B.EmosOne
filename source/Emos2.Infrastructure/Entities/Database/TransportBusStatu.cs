namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TransportBusStatu
    {
        public int ID { get; set; }

        public int BusID { get; set; }

        public int StatusID { get; set; }

        public DateTime StatusOn { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusBy { get; set; }

        [StringLength(350)]
        public string Note { get; set; }

        public virtual TransportBu TransportBu { get; set; }
    }
}
