namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserLogin")]
    public partial class UserLogin
    {
        public long ID { get; set; }

        public int UserID { get; set; }

        public DateTime LogOn { get; set; }

        public string Note { get; set; }

        public int ClientID { get; set; }

        public int? EventID { get; set; }
    }
}
