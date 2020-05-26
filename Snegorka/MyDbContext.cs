using System;
using Microsoft.EntityFrameworkCore;

namespace Snegorka
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public MyDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;UserId=root;Password=0203;port=3307;database=db_snegorka;");
        }
    }
}
