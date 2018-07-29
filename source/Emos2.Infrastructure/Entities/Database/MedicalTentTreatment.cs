namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicalTentTreatment")]
    public partial class MedicalTentTreatment
    {
        public int ID { get; set; }

        public int MedicalTentID { get; set; }

        public int TreatmentID { get; set; }

        public virtual MedicalTent MedicalTent { get; set; }

        public virtual Treatment Treatment { get; set; }
    }
}
