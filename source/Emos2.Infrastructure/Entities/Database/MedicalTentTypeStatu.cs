namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MedicalTentTypeStatu
    {
        public int ID { get; set; }

        public int TypeID { get; set; }

        public int StatusID { get; set; }

        public virtual MedicalTentType MedicalTentType { get; set; }

        public virtual VisitStatu VisitStatu { get; set; }
    }
}
