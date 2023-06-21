using GeminApi.Domain.Helpers;
using GeminApi.Domain.models;
using GeminApi.Domain.portsIn;

namespace GeminApi.Domain.services
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioService(IUnitOfWork _unitOfWork)
        {
            this._unitOfWork = _unitOfWork;
        }

        public async Task<Usuario> CreateUsuario(Usuario usuario)
        {
            await _unitOfWork.UsuarioRepository.AddAsync(usuario);
            await _unitOfWork.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> DeleteUsuario(int idUsuario)
        {
            Usuario usuario = new Usuario();
            try 
            {
                _unitOfWork.BeginTransaction();
                 usuario = await _unitOfWork.UsuarioRepository.GetByIdAsync(idUsuario);
                Usuario usuario1 = await _unitOfWork.UsuarioRepository.GetByIdAsync(2);
                _unitOfWork.UsuarioRepository.Remove(usuario1);
                if (usuario == null)
                {
                    throw new DataNotFoundException("No se encontro el usuario");
                }
                _unitOfWork.Commit();

            }
            catch(Exception ex) 
            {
                _unitOfWork.Rollback();
                throw new DataNotFoundException("No se encontro el usuario");
            }
            _unitOfWork.SaveChangesAsync();
            return usuario;

        }

        public Task<IEnumerable<Usuario>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetUsuarioById(int idusuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> UpdateUsuario(Usuario newAuthor)
        {
            throw new NotImplementedException();
        }
    }
}
