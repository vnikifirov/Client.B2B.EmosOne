namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SendAllMessageTo")]
    public partial class SendAllMessageTo
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int? MessageTypeID { get; set; }

        public int EventID { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
