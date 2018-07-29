namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserData")]
    public partial class UserData : IEntity
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserKey { get; set; }

        public string UserValue { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
