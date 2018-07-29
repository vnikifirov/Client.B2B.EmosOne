namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicalTentDiagnose")]
    public partial class MedicalTentDiagnose
    {
        public int ID { get; set; }

        public int TentID { get; set; }

        public int DiagnoseID { get; set; }

        public virtual Diagnose Diagnose { get; set; }

        public virtual MedicalTent MedicalTent { get; set; }
    }
}
