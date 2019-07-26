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
    public class OptionService : Service<Option> , IOptionService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private OptionService() : base(utk) { }
        private static OptionService _instance;
        public static OptionService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OptionService();
                return _instance;
            }
        }
    }
}
