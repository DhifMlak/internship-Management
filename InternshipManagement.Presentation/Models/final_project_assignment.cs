namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class final_project_assignment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public final_project_assignment()
        {
            documents = new HashSet<document>();
        }

        public long id { get; set; }

        public long convention_name { get; set; }

        public long sheet_id { get; set; }

        public long student_id { get; set; }

        public long? validation_group_id { get; set; }

        public virtual convention convention { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<document> documents { get; set; }

        public virtual validation_group validation_group { get; set; }

        public virtual user user { get; set; }

        public virtual sheet sheet { get; set; }
    }
}
