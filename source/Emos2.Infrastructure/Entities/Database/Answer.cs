namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Answer")]
    public partial class Answer
    {
        public int ID { get; set; }

        public int QuestionID { get; set; }

        public int DistributionID { get; set; }

        public DateTime AnsweredOn { get; set; }

        public string Value { get; set; }

        public virtual Question Question { get; set; }

        public virtual SurveyDistribution SurveyDistribution { get; set; }
    }
}
