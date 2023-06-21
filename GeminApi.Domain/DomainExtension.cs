using GeminApi.Domain.facades;
using GeminApi.Domain.portsIn;
using GeminApi.Domain.services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GeminApi.Domain
{
    public static class DomainExtension
    {
        public static IServiceCollection AddDomain(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUsuarioFacade, UsuarioFacade>();
            serviceCollection.AddScoped<IUsuarioService, UsuarioService>();
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());


            return serviceCollection;
        }
    }
}
