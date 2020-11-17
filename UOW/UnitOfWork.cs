using ApiLoja.Data;
using ApiLoja.Models.Data;
using ApiLoja.Repositories.Interfaces;

namespace ApiLoja.Repositories.UOW
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : Entity
    {
        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IProdutoRepository IProdutoRepository => new ProdutoRepository(_context);
        public ICategoriaRepository ICategoriaRepository => new CategoriaRepository(_context);

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
