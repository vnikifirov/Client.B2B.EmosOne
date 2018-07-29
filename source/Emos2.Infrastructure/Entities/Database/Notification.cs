namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notification")]
    public partial class Notification
    {
        public int ID { get; set; }

        public int CEMUserID { get; set; }

        public int? NotificationTypeID { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
