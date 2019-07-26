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
    public class RoleService : Service<Role>, IRoleService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private RoleService() : base(utk) { }
        private static RoleService _instance;
        public static RoleService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoleService();
                return _instance;
            }
        }
    }
}
