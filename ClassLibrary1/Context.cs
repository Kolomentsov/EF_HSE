using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ClassLibrary1
{
    public class Context : DbContext 

    {
        public Context():base("DBConnect")
        {
            
        }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
