namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TextMessage")]
    public partial class TextMessage
    {
        public long ID { get; set; }

        public int TextMessageTemplateID { get; set; }

        public int? UserID { get; set; }

        public int? GroupID { get; set; }

        [Required]
        [StringLength(200)]
        public string Message { get; set; }

        [StringLength(20)]
        public string SendTo { get; set; }

        [StringLength(20)]
        public string SentFrom { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? SendAt { get; set; }

        public DateTime? SentOn { get; set; }

        public int? Status { get; set; }

        public string ExceptionDesc { get; set; }

        public int? Priority { get; set; }

        public int? RetryCount { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual TextMessageTemplate TextMessageTemplate { get; set; }
    }
}
