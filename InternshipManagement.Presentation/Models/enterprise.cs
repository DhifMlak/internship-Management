namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("enterprise")]
    public partial class enterprise
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public enterprise()
        {
            sheets = new HashSet<sheet>();
        }

        public long id { get; set; }

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
        public string domain { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string email_supervisor { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string web_site { get; set; }

        public long? representative_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sheet> sheets { get; set; }

        public virtual user user { get; set; }
    }
}
