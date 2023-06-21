using GeminApi.Domain.portsOut;

namespace GeminApi.Domain.portsIn
{
    public interface IUnitOfWork: IDisposable
    {
        IUsuarioRepository UsuarioRepository { get; }
        Task SaveChangesAsync();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
