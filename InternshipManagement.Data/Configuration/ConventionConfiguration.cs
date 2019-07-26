using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InternshipManagement.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace InternshipManagement.Data.Configuration
{
    public class ConventionConfiguration : EntityTypeConfiguration<Convention>
    {
        public ConventionConfiguration() { }
    }
}
