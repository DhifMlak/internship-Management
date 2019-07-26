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
    public class UpdateService : Service<Update>, IUpdateService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private UpdateService() : base(utk) { }
        private static UpdateService _instance;
        public static UpdateService Instance {
            get
            {
                if (_instance == null)
                    _instance = new UpdateService();
                return _instance;
            }
        }
    }
}
