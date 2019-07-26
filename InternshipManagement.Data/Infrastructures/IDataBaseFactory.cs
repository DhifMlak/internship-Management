using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipManagement.Data.Infrastructures
{
    public interface IDataBaseFactory : IDisposable
    {
        InternshipManagementAPIContext DataContext { get; }
    }
}
