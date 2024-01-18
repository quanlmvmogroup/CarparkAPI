using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Carpark.Infrastructure.Db
{
    public class CarparkDbContextFactory : IDesignTimeDbContextFactory<CarparkDbContext>
    {
        public CarparkDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("CarparkDb");

            var optionsBuilder = new DbContextOptionsBuilder<CarparkDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new CarparkDbContext(optionsBuilder.Options);
        }
    }
}
