namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParticipantMedicalInfo")]
    public partial class ParticipantMedicalInfo
    {
        public int ID { get; set; }

        public int ParticipantID { get; set; }

        public string Allergies { get; set; }

        public string Medications { get; set; }

        public string GeneralConditions { get; set; }

        [StringLength(50)]
        public string Physician { get; set; }

        [StringLength(50)]
        public string PhysicianPhone { get; set; }

        public string Note { get; set; }

        public virtual Participant Participant { get; set; }
    }
}
