namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserSize")]
    public partial class UserSize
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int SizeTypeID { get; set; }

        public int SizeID { get; set; }

        public DateTime SetOn { get; set; }

        public int? SetBy { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Size Size { get; set; }

        public virtual SizeType SizeType { get; set; }
    }
}
