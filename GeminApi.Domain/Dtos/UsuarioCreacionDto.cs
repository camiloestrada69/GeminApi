using System.ComponentModel.DataAnnotations;

namespace GeminApi.Domain.Dtos
{
    public class UsuarioCreacionDto
    {
        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(255)]
        public string Apellido { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Direccion { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastModified { get; set; }
    }
}
