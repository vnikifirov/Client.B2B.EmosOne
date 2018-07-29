namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserBadge")]
    public partial class UserBadge
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public DateTime IssuedOn { get; set; }

        public int IssuedBy { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
