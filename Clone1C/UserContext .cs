using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Clone1C
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Responsible> Responsibles { get;  set; }
        public DbSet<Estate> Estates { get; set; }
    }
}
