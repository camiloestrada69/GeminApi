using GeminApi.AdapterInHttp;
using GeminApi.AdapterOutRepository;
using GeminApi.AdapterOutRepository.postgreSql;
using GeminApi.Domain;
using GeminApi.Domain.Filters;

namespace GeminApi.App
{
    public class Program
    {
        public static void Main(string[] args)
        {

            IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .AddEnvironmentVariables()
                            .Build();

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddDomain();
            builder.Services.AddPersistence(configuration);

            builder.Services.AddRepository();



            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGenCustomized("Gemin");

            builder.Services.ConfigureVersioning();

            builder.Services.AddMvc(
                config => {
                    config.Filters.Add(typeof(ExceptionManagerFilter));
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}
            app.AllowSwaggerToListApiVersions("Gemin");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}