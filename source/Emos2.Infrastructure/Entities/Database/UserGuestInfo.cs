namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserGuestInfo")]
    public partial class UserGuestInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventID { get; set; }

        [StringLength(250)]
        public string Company { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ArrivalDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DepartureDate { get; set; }

        [StringLength(250)]
        public string Hotel { get; set; }

        public int? EventInterest { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Event Event { get; set; }
    }
}
