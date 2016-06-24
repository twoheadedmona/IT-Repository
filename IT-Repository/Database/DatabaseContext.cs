using IT_Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace IT_Repository.Database
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("name=DatabaseContext")
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Plane> Planes { get; set; }
    }
}
