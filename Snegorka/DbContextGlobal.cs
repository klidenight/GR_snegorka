using System;
using Microsoft.EntityFrameworkCore;

namespace Snegorka
{
    public class DbContextGlobal : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbContextGlobal()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch (Exception)
            {

                System.Windows.MessageBox.Show("Нет соединения с глобальной базой данных. Программа переведена в оффлайн режим.");
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=89.208.196.198;UserId=klidenight;Password=Klide2709;port=3306;database=db_snegorka_glob;");
        }
    }
}
