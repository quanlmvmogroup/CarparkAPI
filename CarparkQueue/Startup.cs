using Carpark.Core.Interfaces;
using Carpark.Core.Services.Impls;
using Carpark.Core.Services.Interfaces;
using Carpark.Infrastructure.Db;
using Carpark.Infrastructure.Respositories;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(CarparkQueue.Startup))]
namespace CarparkQueue
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var config = builder.GetContext().Configuration;

            builder.Services.AddDbContext<CarparkDbContext>(options =>
                options.UseSqlServer(config["ConnectionStrings:CarparkDb"]));

            builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            builder.Services.AddTransient<ICarparkRepository, CarparkRepository>();
            builder.Services.AddTransient<IImportFileService, ImportFileService>();
        }
    }
}
