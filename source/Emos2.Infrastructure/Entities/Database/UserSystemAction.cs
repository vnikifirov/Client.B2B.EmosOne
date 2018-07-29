namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserSystemAction")]
    public partial class UserSystemAction : IEntity 
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int SystemActionID { get; set; }

        public DateTime SetOn { get; set; }

        public int? SetBy { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
