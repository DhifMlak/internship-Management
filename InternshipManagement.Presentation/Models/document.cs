namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("document")]
    public partial class document
    {
        public long id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? date_fichier_alf { get; set; }

        [MaxLength(255)]
        public byte[] fichier_alfresco { get; set; }

        [StringLength(255)]
        public string format_fichier_alf { get; set; }

        [StringLength(255)]
        public string id_fichier_alf { get; set; }

        [StringLength(255)]
        public string nom_fichier_alf { get; set; }

        [StringLength(255)]
        public string path_fichier_alf { get; set; }

        public bool? present { get; set; }

        public long? size_fichier_alf { get; set; }

        public long? final_project_assignment_id { get; set; }

        public virtual final_project_assignment final_project_assignment { get; set; }
    }
}
