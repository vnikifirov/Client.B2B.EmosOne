namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerGroupAssignment")]
    public partial class VolunteerGroupAssignment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VolunteerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        public int VolunteerLevelID { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdateOn { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual VolunteerGroup VolunteerGroup { get; set; }
    }
}
