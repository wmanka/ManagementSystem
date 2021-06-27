using ManagementSystem.Domain.Entities;
using System.Data.Entity;

namespace ManagementSystem.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("ManagementSystem")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DataContext>());
        }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(DataContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
