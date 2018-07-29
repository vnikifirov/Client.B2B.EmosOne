namespace Emos2.Infrastructure.Entities.Database
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

        public int? CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public int PlatformType { get; set; }

        public int Type { get; set; }

        [Required]
        public string Note { get; set; }

        [Required]
        [StringLength(200)]
        public string ConatctEmail { get; set; }

        [StringLength(500)]
        public string FileName { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupportTicketStatu> SupportTicketStatus { get; set; }
    }
}
