namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserVolunteerJob")]
    public partial class UserVolunteerJob
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VolunteerJobID { get; set; }

        public bool PrimaryManager { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual VolunteerJob VolunteerJob { get; set; }
    }
}
