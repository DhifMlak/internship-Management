﻿using System;
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
    public class FieldService : Service<Field>, IFieldService
    {
        private static IDataBaseFactory factory = DataBaseFactory.Instance;
        private static IUnitOfWork utk = new UnitOfWork(factory);
        private FieldService() : base(utk) { }
        private static FieldService _instance;
        public static FieldService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FieldService();
                return _instance;
            }
        }
    }
}
