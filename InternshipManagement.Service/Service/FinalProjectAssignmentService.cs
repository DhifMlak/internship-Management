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
    public class FinalProjectAssignmentService : Service<FinalProjectAssignment>, IFinalProjectAssignmentService
    {
        private static IDataBaseFactory f = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(f);
        private FinalProjectAssignmentService() : base (utk) { }
        private static FinalProjectAssignmentService _instance;
        public static FinalProjectAssignmentService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FinalProjectAssignmentService();
                return _instance;
            }
        }
    }
}
