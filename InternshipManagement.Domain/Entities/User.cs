using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using Microsoft.AspNetCore.Identity;


namespace InternshipManagement.Domain.Entities
{
    public class User : IdentityUser<int>
    {
        [Required(ErrorMessage = "The First Name field is required!")]
        public string FirstName { get; set; }

        [NotMapped]
        public string Password { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Level { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public bool Available { get; set; } = true;

        public bool IsInternal { get; set; }
        public bool IsBlocked { get; set; } = false;
        public bool Req { get; set; }
        public DateTime Tokendate { get; set; }
        public DateTime CreatedAt { get; set; }
        public Nullable<DateTime> LastUpdated { get; set; }
        public List<UserNotification> UserNotifications { get; set; }

        public override string ToString()
        {
            return string.Concat(FirstName, " ", LastName);

        }
    }
}
