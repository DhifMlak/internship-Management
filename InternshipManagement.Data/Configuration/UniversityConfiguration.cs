using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using InternshipManagement.Domain.Entities;

namespace InternshipManagement.Data.Configuration
{
    public class UniversityConfiguration : EntityTypeConfiguration<University>
    {
        public UniversityConfiguration() { }
    }
}
