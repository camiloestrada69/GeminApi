using AutoMapper;
using GeminApi.Domain.Dtos;
using GeminApi.Domain.models;
using GeminApi.Domain.portsIn;
using GeminApi.Domain.Validator;

namespace GeminApi.Domain.facades
{
    public class UsuarioFacade : IUsuarioFacade
    {
        private readonly IMapper _mapper;
        private readonly IUsuarioService _usuarioService;
        private readonly UsuarioValidator validator;

        public UsuarioFacade(IMapper mapper, IUsuarioService _usuarioService)
        {
            this._mapper = mapper;
            this._usuarioService = _usuarioService;
            validator = new UsuarioValidator();
        }

        public Task<UsuarioCreacionDto> GetUsuarioById(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioCreacionDto> CreateUsuario(UsuarioCreacionDto nuevoUsuario)
        {
            var validation =  validator.Validate(nuevoUsuario);
            if (validation.IsValid)
            {
                Console.WriteLine("Es valido");
            }
            var response = await _usuarioService.CreateUsuario(_mapper.Map<Usuario>(nuevoUsuario));
            return _mapper.Map<UsuarioCreacionDto>(response);
        }

        public async Task<Usuario> DeleteUsuarioById(int idUsuarioId)
        {
            Usuario usuario = await _usuarioService.DeleteUsuario(idUsuarioId);
            return usuario;
        }
    }
}
