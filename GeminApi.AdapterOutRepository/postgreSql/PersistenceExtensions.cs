using GeminApi.AdapterOutRepository.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GeminApi.AdapterOutRepository.postgreSql
{
    public static class PersistenceExtensions
    {
        public static void AddPersistence(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DevPostgresDb")));
        }
    }
}
