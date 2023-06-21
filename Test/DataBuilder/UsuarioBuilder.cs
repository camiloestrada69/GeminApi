using GeminApi.Domain.Dtos;
using GeminApi.Domain.models;
using NSubstitute.Routing.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DataBuilder
{
    public class UsuarioBuilder: Usuario
    {
        public UsuarioBuilder() {
            Nombre = "Camilo";
            Apellido = "Estrada";
            FechaNacimiento = DateTime.Now;
            Telefono = "Diaz";
            Email = "camilo@gmail.com";
            Direccion = "Calle 80";
        }

        public Usuario usuarioCreado()
        {
            Nombre = "Camilo";
            Apellido = "Estrada";
            FechaNacimiento = DateTime.Now;
            Telefono = "Diaz";
            Email = "camilo@gmail.com";
            Direccion = "Calle 80";
            return this;
        }
    }
}
