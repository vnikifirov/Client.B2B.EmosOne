namespace Emos2.Infrastructure.Entities.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SizeType")]
    public partial class SizeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SizeType()
        {
            Items = new HashSet<Item>();
            Sizes = new HashSet<Size>();
            UserSizes = new HashSet<UserSize>();
            VolunteerSizes = new HashSet<VolunteerSize>();
            CEMUsers = new HashSet<CEMUser>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public bool? AskOnRegistration { get; set; }

        public bool? Active { get; set; }

        public int? TypeID { get; set; }

        public bool? AskOnVolunteerRegistration { get; set; }

        public string RegPageText { get; set; }

        [StringLength(50)]
        public string SizeChartImageName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Size> Sizes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSize> UserSizes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerSize> VolunteerSizes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CEMUser> CEMUsers { get; set; }
    }
}
