namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisitContactNote")]
    public partial class VisitContactNote
    {
        public int ID { get; set; }

        public int VisitID { get; set; }

        public int UserID { get; set; }

        public int TypeID { get; set; }

        [Required]
        [StringLength(250)]
        public string Note { get; set; }

        public DateTime Date { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Visit Visit { get; set; }
    }
}
