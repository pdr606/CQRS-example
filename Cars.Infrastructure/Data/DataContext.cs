using Cars.Infrastructure.Config.CarContext;
using crqs.example.domain.Enties.CarContext;
using crqs.example.domain.Enties.Notifications;
using Microsoft.EntityFrameworkCore;

namespace Cars.Infrastructure.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfiguration(new CarConfig());
            modelBuilder.ApplyConfiguration(new StatsConfig());
        }

        DbSet<CarEntity> Cars { get; set; }
    }
}
