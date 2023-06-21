using GeminApi.Domain.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GeminApi.AdapterOutRepository.Data.Configurations
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Created)
                .HasColumnName("created");

            builder
                .Property(x => x.LastModified)
                .HasColumnName("last_modified");

            builder
                .Property(x => x.Id)
                .UseIdentityColumn()
                .HasColumnName("id");

            builder
               .Property(x => x.Nombre)
               .IsRequired()
               .HasMaxLength(255)
               .HasColumnName("nombre");

            builder
               .Property(x => x.Apellido)
               .IsRequired()
               .HasMaxLength(255)
               .HasColumnName("apellido");

            builder
               .Property(x => x.FechaNacimiento)
               .IsRequired()
               .HasColumnName("fecha_nacimiento");

            builder
               .Property(x => x.Telefono)
               .IsRequired()
               .HasMaxLength(255)
               .HasColumnName("telefono");

            builder
               .Property(x => x.Email)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnName("email");

            builder
               .Property(x => x.Direccion)
               .IsRequired()
               .HasMaxLength(255)
               .HasColumnName("direccion");
        }
    }
}
