namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRadioChannel")]
    public partial class UserRadioChannel
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RadioChannelID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SetOn { get; set; }

        public int? SetBy { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual RadioChannel RadioChannel { get; set; }
    }
}
