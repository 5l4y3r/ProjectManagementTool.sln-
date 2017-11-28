using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses
{
    public class PmtContext : DbContext
    {
        public PmtContext(): base("name=ProjectManagementDb")
        {
        }
        public DbSet<User> Users{ get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ResourcePerson> ResourcePersons { get; set; }
        public DbSet<EntityClasses.Task>Tasks { get; set; }
        public DbSet<Comment> Comments { get; set; }
       
    }
}
