namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SecurityIssueStatu
    {
        public int ID { get; set; }

        public int StatusID { get; set; }

        public int SecurityIssueID { get; set; }

        public int StatusBy { get; set; }

        public DateTime StatusOn { get; set; }

        public virtual CEMUser CEMUser { get; set; }
    }
}
