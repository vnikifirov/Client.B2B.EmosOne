namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserJob")]
    public partial class UserJob
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        public DateTime? AssignedOn { get; set; }

        public int? AssignedBy { get; set; }

        public DateTime? UnassignedOn { get; set; }

        public int? UnassignedBy { get; set; }

        public DateTime? InvitedOn { get; set; }

        public int? InvitedBy { get; set; }

        public DateTime? AcceptedRejectedOn { get; set; }

        public DateTime? ConfirmedOn { get; set; }

        public int? ConfirmedBy { get; set; }

        public int StatusID { get; set; }

        public bool? NoHotel { get; set; }

        public bool? NoAirfare { get; set; }

        public bool? NoParking { get; set; }

        public string Note { get; set; }

        public DateTime? WorkedSetOn { get; set; }

        public int? WorkedSetBy { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual CEMUser CEMUser1 { get; set; }

        public virtual Job Job { get; set; }
    }
}
