﻿namespace GeminApi.Domain.models
{
    public class Usuario: AuditableBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; } 
    }
}
