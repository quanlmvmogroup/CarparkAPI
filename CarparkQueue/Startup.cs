using Carpark.BL.Services.Impls;
using Carpark.BL.Services.Interfaces;
using Carpark.Data.CarparkDbContext;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(CarparkQueue.Startup))]
namespace CarparkQueue
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var context = builder.GetContext();

            // Retrieve the connection string from the settings.
            var connectionString = context.Configuration.GetConnectionString("CarparkDb")
                                   ?? context.Configuration["CarparkDb"];

            builder.Services.AddDbContext<CarparkDbContext>(options =>
                    options.UseSqlServer(connectionString));

            builder.Services.AddScoped<IImportFileBiz, ImportFileBiz>();
        }
    }
}
