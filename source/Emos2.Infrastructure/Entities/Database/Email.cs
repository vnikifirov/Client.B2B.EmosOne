namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Email")]
    public partial class Email
    {
        public long ID { get; set; }

        public int EmailTemplateID { get; set; }

        public int? UserID { get; set; }

        public int? GroupID { get; set; }

        public string Body { get; set; }

        [Required]
        [StringLength(100)]
        public string EmailTo { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? SendAt { get; set; }

        public DateTime? SentOn { get; set; }

        public int? Status { get; set; }

        public string ExceptionDesc { get; set; }

        public int? Priority { get; set; }

        public int? RetryCount { get; set; }

        [StringLength(250)]
        public string ReplyTo { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual EmailTemplate EmailTemplate { get; set; }
    }
}
