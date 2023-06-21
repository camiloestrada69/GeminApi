using GeminApi.Domain.models;
using Microsoft.EntityFrameworkCore;

namespace GeminApi.AdapterOutRepository.Data.Configurations
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsuarioConfig());
        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();

    }
}
