//using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Zedcrest_Task.Models;

namespace Zedcrest_Task.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public  DbSet<User> Users{ get; set; }
        public DbSet<Wallet> Wallets { get; set; }
    }
}
