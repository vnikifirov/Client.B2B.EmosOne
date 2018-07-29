namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportLog")]
    public partial class ImportLog
    {
        public int ID { get; set; }

        public int Type { get; set; }

        public int RowCount { get; set; }

        public int ExceptionCount { get; set; }

        public int SuccessCount { get; set; }

        [Required]
        [StringLength(250)]
        public string ImportFileName { get; set; }

        [Required]
        [StringLength(250)]
        public string ExceptionFileName { get; set; }

        public int UserID { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public int EventID { get; set; }

        public int Status { get; set; }
    }
}
