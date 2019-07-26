using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InternshipManagement.Domain.Entities
{
    public class Notification
    {
        public enum NotificationStates
        {
            Read,
            unread
        }
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string Description { get; set; }
        public DateTime SysNotifDate { get; set; }
        public NotificationStates State { get; set; }
        public int IdElement { get; set; }
        public string TypeElement { get; set; }
        public List<UserNotification> UserNotifications { get; set; }


    }
}
