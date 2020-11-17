using ApiLoja.Data;
using ApiLoja.Models;
using ApiLoja.Repositories.Generics;
using ApiLoja.Repositories.Interfaces;

namespace ApiLoja.Repositories
{
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(DatabaseContext context)
            : base(context)
        {
        }
    }
}
