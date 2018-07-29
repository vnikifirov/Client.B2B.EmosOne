namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BannerNotification")]
    public partial class BannerNotification
    {
        public int ID { get; set; }

        [Required]
        public string Notification { get; set; }

        public int Priority { get; set; }

        public bool Active { get; set; }

        public int? ApplicationID { get; set; }
    }
}
