using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipManagement.Domain.Entities
{
    public class UserNotification
    {
        //[Key]
        //public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int NotificationId { get; set; }
        public Notification Notification { get; set; }
    }
}
