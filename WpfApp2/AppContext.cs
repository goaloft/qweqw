using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WpfApp2
{

    class AppContext : DbContext
    {
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<User> Userss { get; set; }
        public DbSet<Client> Clients { get; set; }

        public AppContext() : base ("DefaultConnection") { }
    }
}