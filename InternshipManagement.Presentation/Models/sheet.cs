namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sheet")]
    public partial class sheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sheet()
        {
            final_project_assignment = new HashSet<final_project_assignment>();
            grades = new HashSet<grade>();
            users = new HashSet<user>();

        }

        public long id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created { get; set; }

        [StringLength(255)]
        public string description { get; set; }
        [StringLength(255)]
        public string note { get; set; }

        [StringLength(255)] 
        public string etat { get; set; }
        public bool internship_director_validation { get; set; }

        [StringLength(255)]
        public string problematique { get; set; }

        public double? note_encadrant { get; set; }
        public double? note_rapporteur { get; set; }

        [StringLength(255)]
        public string project_title { get; set; }

        [StringLength(255)]
        public string student_name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated { get; set; }

        public long? cat_id { get; set; }

        public long? enterprise_id { get; set; }

        public virtual category category { get; set; }

        public virtual enterprise enterprise { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<final_project_assignment> final_project_assignment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<grade> grades { get; set; }
        public virtual user user { get; set; }
        public virtual ICollection<user> users { get; set; }

    }
}
