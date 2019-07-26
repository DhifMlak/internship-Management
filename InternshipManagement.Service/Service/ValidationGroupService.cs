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

    public class ValidationGroupService : Service<ValidationGroup>, IValidationGroupService
    {
        private static IDataBaseFactory dbf = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(dbf);
        private ValidationGroupService() : base(utk) { }
        private static ValidationGroupService _instance;
        public static IValidationGroupService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ValidationGroupService();
                return _instance;
            }
        }
    }
}
