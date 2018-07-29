namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Translator")]
    public partial class Translator
    {
        public int ID { get; set; }

        public int EventID { get; set; }

        public int UserID { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Event Event { get; set; }
    }
}
