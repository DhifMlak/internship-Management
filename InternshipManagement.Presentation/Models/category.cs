namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("category")]
    public partial class category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public category()
        {
            sheets = new HashSet<sheet>();
            users = new HashSet<user>();
        }

        public long id { get; set; }

        public bool active { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? allowed { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created { get; set; }

        [StringLength(255)]
        public string label { get; set; }

        public long maker_id { get; set; }

        public long uni_id { get; set; }

        public virtual user user { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sheet> sheets { get; set; }

        public virtual university university { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
    }
}
