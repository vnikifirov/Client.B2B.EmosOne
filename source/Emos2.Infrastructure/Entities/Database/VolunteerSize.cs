namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerSize")]
    public partial class VolunteerSize
    {
        public int ID { get; set; }

        public int VolunteerID { get; set; }

        public int SizeTypeID { get; set; }

        public int SizeID { get; set; }

        public DateTime SetOn { get; set; }

        public int? SetBy { get; set; }

        public virtual Size Size { get; set; }

        public virtual SizeType SizeType { get; set; }
    }
}
