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
    public class SheetService : Service<Sheet>, ISheetService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private SheetService() : base(utk) { }
        private static SheetService _instance;
        public static SheetService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SheetService();
                return _instance;
            }
        }
    }
}
