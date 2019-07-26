using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternshipManagement.Data.Infrastructures;
using InternshipManagement.Domain.Entities;
using InternshipManagement.ServicePattern;
using InternshipManagement.Service.IService;

namespace InternshipManagement.Service.Service
{
    public class UserNotificationService : Service<UserNotification>, IUserNotificationService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private UserNotificationService() : base(utk) { }
        private static UserNotificationService _instance;
        public static UserNotificationService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserNotificationService();
                return _instance;
            }
        }
    }
}
