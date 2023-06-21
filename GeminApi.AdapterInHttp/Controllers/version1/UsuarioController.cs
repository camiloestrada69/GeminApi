using GeminApi.Domain.Dtos;
using GeminApi.Domain.Filters;
using GeminApi.Domain.Helpers;
using GeminApi.Domain.models;
using GeminApi.Domain.portsIn;
using GeminApi.Domain.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace GeminApi.AdapterInHttp.Controllers.version1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsuarioV1Controller: ControllerBase
    {
        private readonly IUsuarioFacade _usuarioFacade;
        private readonly ILogger<UsuarioV1Controller> _logger;

        public UsuarioV1Controller(IUsuarioFacade usuarioFacade, ILogger<UsuarioV1Controller> logger)
        {
            _usuarioFacade = usuarioFacade;
            _logger = logger;
        }

        /// <summary>
        /// Permite crear un autor
        /// </summary>
        /// <param name="author"></param>
        /// <returns>Nuevo autor creado</returns>
        /// <response code="200">El autor se ha crado correctamente</response>
        /// <response code="400">La petición es inválida</response>  
        /// <response code="500">Error interno al procesar la respuesta</response>  
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<StandardResponse<UsuarioCreacionDto>> CreateAuthor([FromBody] UsuarioCreacionDto nuevoUsuario)
        {
            _logger.LogInformation("Se crea un nuevo usuario");
            return new StandardResponse<UsuarioCreacionDto>(HttpStatusCode.Created,
                "Usuario guardado exitosamente",
                await _usuarioFacade.CreateUsuario(nuevoUsuario)
                );
        }

        /// <summary>
        /// Bussines
        /// </summary>
        /// <param name="author"></param>
        /// <returns>Nuevo autor creado</returns>
        /// <response code="200">El autor se ha crado correctamente</response>
        /// <response code="400">La petición es inválida</response>  
        /// <response code="500">Error interno al procesar la respuesta</response>  
        /// <summary>
        /// Permite consultar todos los libros
        /// </summary>
        /// <returns>Todos los libros actuales</returns>
        /// <response code="200">Los libros se han consultado exitosamente</response>
        /// <response code="400">La petición es inválida</response>  
        /// <response code="500">Error interno al procesar la respuesta</response>  
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<StandardResponse<IEnumerable<UsuarioCreacionDto>>> GetAll()
        {
            throw new BusinesException("Bussines error");
        }

        /// <summary>
        /// Permite eliminar un autor
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns>Usuario eliminado</returns>
        /// <response code="200">El usuario se ha eliminado exitosamente</response>
        /// <response code="400">La petición es inválida</response>  
        /// <response code="500">Error interno al procesar la respuesta</response>  
        [HttpDelete("{idUsuario}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<StandardResponse<Usuario>> DeleteAuthor(int idUsuario)
        {
            _logger.LogInformation("Se elimina un usuario", idUsuario);
            return new StandardResponse<Usuario>(HttpStatusCode.Accepted,
                "Usuario eliminado exitosamente",
                await _usuarioFacade.DeleteUsuarioById(idUsuario)
                );
        }




    }
}
