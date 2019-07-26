namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class validation_group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public validation_group()
        {
            final_project_assignment = new HashSet<final_project_assignment>();
        }

        public long id { get; set; }

        public bool valid_internship_director { get; set; }

        public bool valid_pre_validator { get; set; }

        public bool valid_president { get; set; }

        public bool valid_reporter { get; set; }

        public bool valid_supervisor { get; set; }

        public long? internship_director_id { get; set; }

        public long? pre_validator_id { get; set; }

        public long? president_id { get; set; }

        public long? reporter_id { get; set; }

        public long? supervisor_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<final_project_assignment> final_project_assignment { get; set; }

        public virtual user user { get; set; }

        public virtual user user1 { get; set; }

        public virtual user user2 { get; set; }

        public virtual user user3 { get; set; }

        public virtual user user4 { get; set; }
    }
}
