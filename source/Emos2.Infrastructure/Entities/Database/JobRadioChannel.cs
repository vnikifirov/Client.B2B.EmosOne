namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobRadioChannel")]
    public partial class JobRadioChannel
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RadioChannelID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? SetOn { get; set; }

        public int? SetBy { get; set; }

        public virtual Job Job { get; set; }

        public virtual RadioChannel RadioChannel { get; set; }
    }
}
