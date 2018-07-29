namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupportTicket")]
    public partial class SupportTicket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SupportTicket()
        {
            SupportTicketStatus = new HashSet<SupportTicketStatu>();
        }

        public int ID { get; set; }

        public int? EventID { get; set; }

        [StringLength(20)]
        public string TicketNumber { get; set; }

        public int PlatformType { get; set; }

        public int TypeID { get; set; }

        [Required]
        [StringLength(200)]
        public string ConatctEmail { get; set; }

        [StringLength(200)]
        public string FileName { get; set; }

        public int ClientID { get; set; }

        public int AccessTypeID { get; set; }

        public virtual Client Client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupportTicketStatu> SupportTicketStatus { get; set; }
    }
}
