namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Question")]
    public partial class Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Question()
        {
            Answers = new HashSet<Answer>();
            QuestionOptions = new HashSet<QuestionOption>();
        }

        public int ID { get; set; }

        public int SurveyID { get; set; }

        [StringLength(150)]
        public string QuestionGroup { get; set; }

        [Required]
        public string Text { get; set; }

        public int? OrderNo { get; set; }

        public int? CriticalValue { get; set; }

        public int TypeID { get; set; }

        public int ValidationTypeID { get; set; }

        public bool Required { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }

        public virtual Survey Survey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
    }
}
