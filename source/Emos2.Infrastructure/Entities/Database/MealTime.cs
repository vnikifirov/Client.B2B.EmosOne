namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MealTime")]
    public partial class MealTime
    {
        public int ID { get; set; }

        public int MealID { get; set; }

        public DateTime TimeFrom { get; set; }

        public DateTime? TimeTo { get; set; }

        public string Menu { get; set; }

        public int? Quantity { get; set; }

        [StringLength(20)]
        public string MealType { get; set; }

        public virtual Meal Meal { get; set; }
    }
}
