namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SurveyDistribution")]
    public partial class SurveyDistribution
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SurveyDistribution()
        {
            Answers = new HashSet<Answer>();
        }

        public int ID { get; set; }

        public int SurveyID { get; set; }

        [Required]
        [StringLength(50)]
        public string Distribution { get; set; }

        public Guid GUID { get; set; }

        public int? VolunteerID { get; set; }

        public int? UserID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer> Answers { get; set; }

        public virtual CEMUser CEMUser { get; set; }

        public virtual Survey Survey { get; set; }

        public virtual Volunteer Volunteer { get; set; }
    }
}
