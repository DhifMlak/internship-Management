namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class option
    {
        public long id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? created { get; set; }

        [StringLength(255)]
        public string label { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? updated { get; set; }

        public long? department_id { get; set; }

        public virtual department department { get; set; }
    }
}
