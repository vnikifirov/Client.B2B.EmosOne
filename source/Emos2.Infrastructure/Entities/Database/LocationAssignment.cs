namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocationAssignment")]
    public partial class LocationAssignment
    {
        public int ID { get; set; }

        public int LocationID { get; set; }

        public int AssignTo { get; set; }

        public int AuthorizeBy { get; set; }

        public DateTime AssignDate { get; set; }

        public int? LocationTo { get; set; }

        public string Note { get; set; }

        public int EventID { get; set; }

        public int StatusID { get; set; }

        public int? BoxCount { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CEMUser CEMUser1 { get; set; }

        public virtual Event Event { get; set; }

        public virtual Location Location { get; set; }
    }
}
