using GeminApi.AdapterOutRepository.Data.Configurations;
using GeminApi.AdapterOutRepository.Data.repositories;
using GeminApi.Domain.portsIn;
using GeminApi.Domain.portsOut;

namespace GeminApi.AdapterOutRepository.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private UsuarioRepository _usuarioRepository;

        public IUsuarioRepository UsuarioRepository => _usuarioRepository ??= new UsuarioRepository(_context);

        public UnitOfWork(AppDbContext context) { _context = context; }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void BeginTransaction()
        {
            _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            _context.Database.CommitTransaction();
        }

        public void Rollback()
        {
            _context.Database.RollbackTransaction();
        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}
