using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Cars.Infrastructure.Data
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {


            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=Cars; User ID=pedrosa; Password=develop; TrustServerCertificate=true");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
