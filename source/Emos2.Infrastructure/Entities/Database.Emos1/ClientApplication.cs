namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientApplication")]
    public partial class ClientApplication
    {
        public int ID { get; set; }

        public int ClientID { get; set; }

        [Required]
        [StringLength(50)]
        public string AppName { get; set; }

        [StringLength(200)]
        public string AppLink { get; set; }

        public virtual Client Client { get; set; }
    }
}
