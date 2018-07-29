namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserCategory")]
    public partial class UserCategory
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string RegisterURL { get; set; }

        [StringLength(250)]
        public string RedirectURL { get; set; }
    }
}
