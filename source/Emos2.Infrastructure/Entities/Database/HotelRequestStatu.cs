namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HotelRequestStatu
    {
        public int ID { get; set; }

        public int HotelRequestID { get; set; }

        public int StatusID { get; set; }

        public DateTime StatusOn { get; set; }

        public int? StatusBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CheckIn { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CheckOut { get; set; }

        public int? HotelID { get; set; }

        [StringLength(100)]
        public string RoomType { get; set; }

        public string Note { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Hotel Hotel { get; set; }

        public virtual HotelRequest HotelRequest { get; set; }
    }
}
