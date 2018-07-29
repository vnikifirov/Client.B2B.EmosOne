namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TextMessageTemplate")]
    public partial class TextMessageTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TextMessageTemplate()
        {
            TextMessages = new HashSet<TextMessage>();
        }

        public int ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Message { get; set; }

        public int Direction { get; set; }

        public int MessageServiceAccountID { get; set; }

        public int TypeID { get; set; }

        public int EventID { get; set; }

        public int? CreatedBy { get; set; }

        public virtual MessageServiceAccount MessageServiceAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TextMessage> TextMessages { get; set; }
    }
}
