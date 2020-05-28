using System;
using Microsoft.EntityFrameworkCore;

namespace Snegorka
{
    public class DbContextLocal : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbContextLocal()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;UserId=root;Password=0203;port=3307;database=db_snegorka_local;");
        }
    }
}
