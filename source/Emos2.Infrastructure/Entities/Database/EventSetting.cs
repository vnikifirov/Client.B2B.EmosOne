namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventSetting")]
    public partial class EventSetting
    {
        public int ID { get; set; }

        public int EventID { get; set; }

        [Required]
        [StringLength(50)]
        public string SettingKey { get; set; }

        public string Value { get; set; }

        public virtual Event Event { get; set; }
    }
}
