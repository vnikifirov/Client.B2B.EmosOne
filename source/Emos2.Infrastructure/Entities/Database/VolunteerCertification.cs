namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VolunteerCertification")]
    public partial class VolunteerCertification
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VolunteerID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CertficationID { get; set; }

        public DateTime? StatusOn { get; set; }

        public int? StatusBy { get; set; }

        public int StatusId { get; set; }

        [StringLength(50)]
        public string ImageName { get; set; }

        [StringLength(50)]
        public string CertificateNumber { get; set; }

        [StringLength(50)]
        public string IssuingState { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpirationDate { get; set; }

        public bool? IsSameName { get; set; }

        public bool? IsInGoodStanding { get; set; }

        public bool? IsFreeOfRestrictions { get; set; }

        public string Note { get; set; }

        public virtual SkillCertification SkillCertification { get; set; }
    }
}
