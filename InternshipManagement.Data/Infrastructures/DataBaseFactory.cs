using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipManagement.Data.Infrastructures
{
    public class DataBaseFactory : Disposable, IDataBaseFactory
    {

        private InternshipManagementAPIContext datacontext;

        public InternshipManagementAPIContext DataContext
        {
            get { return datacontext; }

        }

        private DataBaseFactory()
        {
            datacontext = InternshipManagementAPIContext.Instance;
        }

        private static DataBaseFactory _instance;
        public static DataBaseFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataBaseFactory();
                return _instance;
            }
        }

        public override void DisposeCore()
        {
            if (datacontext != null)
                datacontext.Dispose();
        }
    }
}
