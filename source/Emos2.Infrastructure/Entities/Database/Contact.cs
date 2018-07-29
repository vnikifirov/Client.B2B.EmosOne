namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contact")]
    public partial class Contact
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        public string Note { get; set; }

        public bool Active { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
