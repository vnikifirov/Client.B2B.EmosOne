namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Weather")]
    public partial class Weather
    {
        public int ID { get; set; }

        public decimal? humidity { get; set; }

        public decimal? temperature { get; set; }

        public int? windspeed { get; set; }

        [StringLength(50)]
        public string winddisplay { get; set; }

        public DateTime? observationtime { get; set; }

        [StringLength(100)]
        public string skytext { get; set; }

        public int EventID { get; set; }

        public int? HeatIndex { get; set; }

        public virtual Event Event { get; set; }
    }
}
