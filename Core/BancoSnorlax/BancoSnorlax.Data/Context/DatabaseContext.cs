using BancoSnorlax.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BancoSnorlax.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured) 
                optionsBuilder.UseSqlite(@"Data Source=..\BancoSnorlax.db");
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
