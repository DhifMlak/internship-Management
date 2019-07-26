namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("university")]
    public partial class university
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public university()
        {
            categories = new HashSet<category>();
            classes = new HashSet<_class>();
            conventions = new HashSet<convention>();
            departments = new HashSet<department>();
            users = new HashSet<user>();
        }

        public long id { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string address1 { get; set; }

        [StringLength(255)]
        public string address2 { get; set; }

        [StringLength(255)]
        public string city { get; set; }

        [StringLength(255)]
        public string state { get; set; }

        [StringLength(255)]
        public string street { get; set; }

        public long zip_code { get; set; }

        [StringLength(255)]
        public string fax { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string registration_number { get; set; }

        [StringLength(255)]
        public string tel { get; set; }

        [StringLength(255)]
        public string web_site { get; set; }

        public long representative_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<category> categories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<_class> classes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<convention> conventions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<department> departments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }

        public virtual user user { get; set; }
    }
}
