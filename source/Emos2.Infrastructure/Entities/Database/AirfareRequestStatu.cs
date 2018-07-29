namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AirfareRequestStatu
    {
        public int ID { get; set; }

        public int AirfareRequestID { get; set; }

        public int StatusID { get; set; }

        public DateTime StatusOn { get; set; }

        public int? StatusBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DepartDate { get; set; }

        [StringLength(50)]
        public string DepartTime { get; set; }

        [StringLength(50)]
        public string DepartArrivalTime { get; set; }

        [StringLength(250)]
        public string DepartAirport { get; set; }

        [StringLength(50)]
        public string DepartFlightNumber { get; set; }

        [StringLength(10)]
        public string DepartSeatNumber { get; set; }

        [StringLength(250)]
        public string ArriveAirport { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReturnDate { get; set; }

        [StringLength(50)]
        public string ReturnTime { get; set; }

        [StringLength(50)]
        public string ReturnArrivalTime { get; set; }

        [StringLength(250)]
        public string ReturnAirport { get; set; }

        [StringLength(50)]
        public string ReturnFlightNumber { get; set; }

        [StringLength(10)]
        public string ReturnSeatNumber { get; set; }

        public string Note { get; set; }

        [StringLength(20)]
        public string TripType { get; set; }

        [StringLength(200)]
        public string DepartAirline { get; set; }

        [StringLength(200)]
        public string ReturnAirline { get; set; }

        public virtual AirfareRequest AirfareRequest { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
