namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMeeting")]
    public partial class UserMeeting
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MeetingID { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime? CheckInOn { get; set; }

        [Column(TypeName = "ntext")]
        public string Note { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Meeting Meeting { get; set; }
    }
}
