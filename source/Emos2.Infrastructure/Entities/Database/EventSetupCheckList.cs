namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventSetupCheckList")]
    public partial class EventSetupCheckList
    {
        public int ID { get; set; }

        public int EventID { get; set; }

        public int TaskID { get; set; }

        public int? StatusID { get; set; }

        public DateTime? DueDateTime { get; set; }

        public DateTime StatusOn { get; set; }

        public int StatusBy { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Event Event { get; set; }
    }
}
