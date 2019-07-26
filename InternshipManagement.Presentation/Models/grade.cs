namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("grade")]
    public partial class grade
    {
        public long id { get; set; }

        [StringLength(255)]
        public string level { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        public double number { get; set; }

        public long maker_id { get; set; }

        public long sheet_id { get; set; }

        public virtual user user { get; set; }

        public virtual sheet sheet { get; set; }
    }
}
