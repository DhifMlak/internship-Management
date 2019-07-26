using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using InternshipManagement.Domain.Entities;

namespace InternshipManagement.Data
{
    public class InternshipManagementAPIContext : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Convention> Convention { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Enterprise> Enterprise { get; set; }
        public DbSet<Field> Field { get; set; }
        public DbSet<FinalProjectAssignment> FinalProjectAssignment { get; set; }
        public DbSet<Form> Form { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<Option> Option { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Sheet> Sheet { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<Update> Update { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserNotification> UserNotification { get; set; }
        public DbSet<ValidationGroup> ValidationGroup { get; set; }

        private  InternshipManagementAPIContext() : base("name=machine")
        { }
        private static InternshipManagementAPIContext _instance;
        public static InternshipManagementAPIContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InternshipManagementAPIContext();
                }
                return _instance;
            }
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
