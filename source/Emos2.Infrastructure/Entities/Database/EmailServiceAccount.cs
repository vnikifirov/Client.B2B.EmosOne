namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailServiceAccount")]
    public partial class EmailServiceAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmailServiceAccount()
        {
            EventEmailServiceAccounts = new HashSet<EventEmailServiceAccount>();
        }

        public int ID { get; set; }

        [StringLength(250)]
        public string EmailSender { get; set; }

        [StringLength(100)]
        public string SMTPServer { get; set; }

        public int? SMTPPort { get; set; }

        [StringLength(50)]
        public string SMTPUsername { get; set; }

        [StringLength(50)]
        public string SMTPPassword { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventEmailServiceAccount> EventEmailServiceAccounts { get; set; }
    }
}
