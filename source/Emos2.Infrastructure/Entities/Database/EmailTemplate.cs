namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailTemplate")]
    public partial class EmailTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailTemplate()
        {
            Emails = new HashSet<Email>();
            EmailTemplateAttachments = new HashSet<EmailTemplateAttachment>();
            EmailTemplateOrganizationalUnits = new HashSet<EmailTemplateOrganizationalUnit>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Subject { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string EmailContent { get; set; }

        public int TypeID { get; set; }

        public int EventID { get; set; }

        public string Placeholders { get; set; }

        public int? CreatedBy { get; set; }

        public int AccountTypeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Email> Emails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailTemplateAttachment> EmailTemplateAttachments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailTemplateOrganizationalUnit> EmailTemplateOrganizationalUnits { get; set; }
    }
}
