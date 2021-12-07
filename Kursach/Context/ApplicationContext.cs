using Microsoft.EntityFrameworkCore;
using Kursach.MVVM.Model;

namespace Kursach.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Service> Services { get; set; }
        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
            //Services.AddRange(new Service { Name = "Замена дисплея", Price = 100 },
            //    new Service { Name = "Замена аккамулятора", Price = 70 }, 
            //    new Service { Name = "Диагностика", Price = 40},
            //    new Service { Name = "Очистка памяти", Price = 30});
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb;Username=postgres;Password=363kYkmJ");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Service>()
        //        .HasKey(a => a.Id).
        //}
    }
}
