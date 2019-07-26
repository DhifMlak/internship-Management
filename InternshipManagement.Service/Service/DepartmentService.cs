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
    public class DepartmentService : Service<Department>, IDepartmentService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private DepartmentService() : base(utk)
        {  }
        private static DepartmentService _instance;
        public static DepartmentService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DepartmentService();
                return _instance;
            }
        }
    }
}
