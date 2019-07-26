namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("convention")]
    public partial class convention
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public convention()
        {
            final_project_assignment = new HashSet<final_project_assignment>();
        }

        public long id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? end_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated { get; set; }

        public bool valid { get; set; }

        public long? university_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<final_project_assignment> final_project_assignment { get; set; }

        public virtual university university { get; set; }
    }
}
