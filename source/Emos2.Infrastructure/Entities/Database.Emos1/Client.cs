namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client : IEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            ClientApplications = new HashSet<ClientApplication>();
            ClientSettings = new HashSet<ClientSetting>();
            SupportTickets = new HashSet<SupportTicket>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Code { get; set; }

        [Required]
        [StringLength(150)]
        public string WebSiteUrl { get; set; }

        [Required]
        [StringLength(150)]
        public string LogoUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string DatabaseName { get; set; }

        [StringLength(100)]
        public string ServerName { get; set; }

        [StringLength(50)]
        public string UserID { get; set; }

        [Required]
        [StringLength(100)]
        public string TimeZoneInfoId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientApplication> ClientApplications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientSetting> ClientSettings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupportTicket> SupportTickets { get; set; }
    }
}
