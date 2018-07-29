namespace Emos2.Infrastructure.Entities.DatabaseEmos1
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

        public int? StatusBy { get; set; }

        public DateTime StatusOn { get; set; }

        public int Status { get; set; }

        [Required]
        public string Note { get; set; }

        public int AccessTypeID { get; set; }

        public virtual SupportTicket SupportTicket { get; set; }
    }
}
