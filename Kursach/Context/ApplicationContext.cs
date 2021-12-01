using Microsoft.EntityFrameworkCore;
using Kursach.MVVM.Model;

namespace Kursach.Context
{
    class ApplicationContext : DbContext
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
