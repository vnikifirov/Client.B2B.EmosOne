namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobShift")]
    public partial class JobShift
    {
        public int ID { get; set; }

        public int JobID { get; set; }

        public DateTime ShiftFrom { get; set; }

        public DateTime ShiftTo { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public virtual Job Job { get; set; }
    }
}
