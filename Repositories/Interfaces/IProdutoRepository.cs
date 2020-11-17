using ApiLoja.Models;
using System.Collections.Generic;

namespace ApiLoja.Repositories
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        List<Produto> ListaProdutos();
    }
}
