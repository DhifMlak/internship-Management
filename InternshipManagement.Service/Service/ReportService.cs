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
    public class ReportService : Service<Report>, IReportService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private ReportService() : base(utk) { }
        private static ReportService _instance;
        public static ReportService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReportService();
                return _instance;
            }
        }
    }
}
