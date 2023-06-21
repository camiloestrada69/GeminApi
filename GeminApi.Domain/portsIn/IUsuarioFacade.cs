using GeminApi.Domain.Dtos;
using GeminApi.Domain.models;

namespace GeminApi.Domain.portsIn
{
    public interface IUsuarioFacade
    {
        Task<UsuarioCreacionDto> GetUsuarioById(int idUsuario);
        Task<UsuarioCreacionDto> CreateUsuario(UsuarioCreacionDto nuevoUsuario);

        Task <Usuario>DeleteUsuarioById(int idUsuarioId);
    }
}
