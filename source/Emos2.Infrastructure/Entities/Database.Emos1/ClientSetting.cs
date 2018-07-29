namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientSetting")]
    public partial class ClientSetting
    {
        public int ID { get; set; }

        public int ClientID { get; set; }

        [Required]
        [StringLength(50)]
        public string SettingKey { get; set; }

        public string Value { get; set; }

        public virtual Client Client { get; set; }

        public virtual Setting Setting { get; set; }
    }
}
