namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class api_auditable_entity
    {
        public long id { get; set; }

        public bool auditable_flag { get; set; }

        [StringLength(255)]
        public string ui_designation { get; set; }

        [StringLength(255)]
        public string ui_designation_eng { get; set; }

        [StringLength(255)]
        public string entity_name { get; set; }
    }
}
