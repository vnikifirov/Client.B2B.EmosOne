namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserCRUD")]
    public partial class UserCRUD
    {
        public int ID { get; set; }

        public int ModuleID { get; set; }

        public int UserID { get; set; }

        public bool? Create { get; set; }

        public bool? Read { get; set; }

        public bool? Update { get; set; }

        public bool? Delete { get; set; }

        public DateTime SetOn { get; set; }

        public int? SetBy { get; set; }

        public bool? Search { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
