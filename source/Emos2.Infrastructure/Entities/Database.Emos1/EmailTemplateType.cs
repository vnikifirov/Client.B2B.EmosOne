namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailTemplateType")]
    public partial class EmailTemplateType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailTemplateType()
        {
            Placeholders = new HashSet<Placeholder>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Subject { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string EmailContent { get; set; }

        public int AccountTypeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Placeholder> Placeholders { get; set; }
    }
}
