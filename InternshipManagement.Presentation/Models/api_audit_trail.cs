namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class api_audit_trail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [StringLength(255)]
        public string action_type { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? time_date { get; set; }

        [StringLength(255)]
        public string ui_designation { get; set; }

        [StringLength(255)]
        public string ui_designation_eng { get; set; }

        [StringLength(255)]
        public string id_obj { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        [StringLength(255)]
        public string user_login { get; set; }

        public string value { get; set; }
    }
}
