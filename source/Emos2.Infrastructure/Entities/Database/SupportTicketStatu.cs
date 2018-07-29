namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupportTicketStatu
    {
        public int ID { get; set; }

        public int SupportTicketID { get; set; }

        public int? ResolvedBy { get; set; }

        public DateTime? ResolvedOn { get; set; }

        public int Status { get; set; }

        public byte[] Note { get; set; }

        public virtual SupportTicket SupportTicket { get; set; }
    }
}
