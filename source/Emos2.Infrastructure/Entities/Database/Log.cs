namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string LogLevel { get; set; }

        public int UserID { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Exception { get; set; }
    }
}
