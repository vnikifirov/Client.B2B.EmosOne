namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VehicleTypeRequestStatu
    {
        public int ID { get; set; }

        public int RequestID { get; set; }

        public int SetBy { get; set; }

        public int Status { get; set; }

        public DateTime Date { get; set; }

        public virtual VehicleTypeRequest VehicleTypeRequest { get; set; }
    }
}
