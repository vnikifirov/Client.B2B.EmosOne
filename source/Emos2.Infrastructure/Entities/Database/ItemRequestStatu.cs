namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ItemRequestStatu
    {
        public int ID { get; set; }

        public int ItemRequestId { get; set; }

        public int StatusId { get; set; }

        public int StatusBy { get; set; }

        public DateTime StatusOn { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual ItemRequest ItemRequest { get; set; }
    }
}
