using GeminApi.AdapterOutRepository.Data.Configurations;
using GeminApi.Domain.models;
using GeminApi.Domain.portsOut;

namespace GeminApi.AdapterOutRepository.Data.repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
