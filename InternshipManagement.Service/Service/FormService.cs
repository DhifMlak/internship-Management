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
    public class FormService: Service<Form> , IFormService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private FormService() : base(utk) { }
        private static FormService _instance;
        public static FormService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormService();
                return _instance;
            }
        }
    }
}
