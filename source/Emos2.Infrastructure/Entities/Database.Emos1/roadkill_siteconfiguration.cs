namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class roadkill_siteconfiguration
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Version { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
