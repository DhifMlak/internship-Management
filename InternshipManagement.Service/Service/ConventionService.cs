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
    public class ConventionService : Service<Convention>, IConventionService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private ConventionService() : base(utk) { }
        private static ConventionService _instance;
        public static ConventionService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConventionService();
                return _instance;
            }
        }
    }
}
