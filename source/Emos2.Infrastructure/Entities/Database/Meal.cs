namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Meal")]
    public partial class Meal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meal()
        {
            MealTimes = new HashSet<MealTime>();
            OrganizationUnits = new HashSet<OrganizationUnit>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public int? EventID { get; set; }

        public virtual Event Event { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealTime> MealTimes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; set; }
    }
}
