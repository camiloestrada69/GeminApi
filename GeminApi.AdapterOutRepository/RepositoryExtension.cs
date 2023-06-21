using GeminApi.AdapterOutRepository.Data;
using GeminApi.Domain.portsIn;
using Microsoft.Extensions.DependencyInjection;

namespace GeminApi.AdapterOutRepository
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepository(this IServiceCollection serviceCollection)
        {
            
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            return serviceCollection;
        }
    }
}
