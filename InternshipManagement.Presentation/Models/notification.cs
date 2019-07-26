namespace InternshipManagement.Presentation.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("notification")]
    public partial class notification
    {
        public long id { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string message { get; set; }

        [StringLength(255)]
        public string mobile { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        public int? state { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? sys_notif_date { get; set; }

        public long? owner_id { get; set; }

        public virtual user user { get; set; }
    }
}
