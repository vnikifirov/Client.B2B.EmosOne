namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailTemplateAttachment")]
    public partial class EmailTemplateAttachment
    {
        public int ID { get; set; }

        public int EmailTemplateID { get; set; }

        [Required]
        [StringLength(200)]
        public string Attachment { get; set; }

        public virtual EmailTemplate EmailTemplate { get; set; }
    }
}
