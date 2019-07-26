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
    public class UniversityService : Service<University>, IUniversityService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private UniversityService() : base(utk) { }
        private static UniversityService _instance;
        public static UniversityService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UniversityService();
                return _instance;
            }
        }
    }
}
