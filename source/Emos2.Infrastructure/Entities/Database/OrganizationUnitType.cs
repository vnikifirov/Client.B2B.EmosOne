namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrganizationUnitType")]
    public partial class OrganizationUnitType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrganizationUnitType()
        {
            OrganizationUnits = new HashSet<OrganizationUnit>();
            Items = new HashSet<Item>();
            Surveys = new HashSet<Survey>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int OrderNo { get; set; }

        public bool Active { get; set; }

        public string RegistrationLink { get; set; }

        public int? RegistrationFiledAvailabilityFlag { get; set; }

        public DateTime? RegistrationStart { get; set; }

        public DateTime? RegistrationEnd { get; set; }

        public string Waiver { get; set; }

        public string MinorWaiver { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Survey> Surveys { get; set; }
    }
}
