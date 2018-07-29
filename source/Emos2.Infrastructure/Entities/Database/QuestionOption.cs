namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QuestionOption
    {
        public long ID { get; set; }

        public int QuestionID { get; set; }

        [Required]
        public string Text { get; set; }

        public virtual Question Question { get; set; }
    }
}
