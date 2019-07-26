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
    public class EnterpriseService : Service<Enterprise>, IEnterpriseService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private EnterpriseService() : base(utk)
        { }
        private static EnterpriseService _instance;
        public static EnterpriseService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EnterpriseService();
                return _instance;
            }
        }
    }
}
