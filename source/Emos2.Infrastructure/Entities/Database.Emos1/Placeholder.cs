namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Placeholder")]
    public partial class Placeholder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Placeholder()
        {
            EmailTemplateTypes = new HashSet<EmailTemplateType>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Tag { get; set; }

        [Required]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmailTemplateType> EmailTemplateTypes { get; set; }
    }
}
