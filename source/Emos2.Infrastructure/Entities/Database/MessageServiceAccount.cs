namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MessageServiceAccount")]
    public partial class MessageServiceAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MessageServiceAccount()
        {
            TextMessageTemplates = new HashSet<TextMessageTemplate>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(255)]
        public string SMSHttpRequest { get; set; }

        [StringLength(50)]
        public string SMSUserName { get; set; }

        [StringLength(50)]
        public string SMSPassword { get; set; }

        [StringLength(50)]
        public string SMSAPI_ID { get; set; }

        [StringLength(50)]
        public string SMSFromNumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TextMessageTemplate> TextMessageTemplates { get; set; }
    }
}
