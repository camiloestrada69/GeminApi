using GeminApi.Domain.models;

namespace GeminApi.Domain.portsIn
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuarioById(int idusuario);

        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario> CreateUsuario(Usuario newAuthor);
        Task<Usuario> UpdateUsuario(Usuario newAuthor);
        Task<Usuario> DeleteUsuario(int idUsuario);
    }
}
