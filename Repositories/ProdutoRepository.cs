using ApiLoja.Data;
using ApiLoja.Models;
using ApiLoja.Repositories.Generics;
using System.Collections.Generic;

namespace ApiLoja.Repositories
{
    public class ProdutoRepository : GenericRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DatabaseContext context)
            : base(context)
        {
        }

        public List<Produto> ListaProdutos()
        {
            var produtos = new List<Produto>();
            return produtos;
        }
    }
}
