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
    public class AddressService : Service<Address>, IAddressService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private AddressService() : base(utk) { }
        private static AddressService _instance;
        public static AddressService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddressService();
                return _instance;
            }
        }
    }
}
