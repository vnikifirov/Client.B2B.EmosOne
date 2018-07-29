namespace Emos2.Infrastructure.Entities.DatabaseEmos1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class roadkill_pages
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public roadkill_pages()
        {
            roadkill_pagecontent = new HashSet<roadkill_pagecontent>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [StringLength(255)]
        public string Tags { get; set; }

        [Required]
        [StringLength(255)]
        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsLocked { get; set; }

        [StringLength(255)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roadkill_pagecontent> roadkill_pagecontent { get; set; }
    }
}
