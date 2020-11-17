using ApiLoja.Models;
using ApiLoja.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiLoja.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IUnitOfWork<Produto> _uow;

        public ProdutoController(IUnitOfWork<Produto> uow)
        {
            _uow = uow;
        }

        [HttpGet]
        public List<Produto> GetAllProdutos()
        {
            return _uow.IProdutoRepository.GetAll();
        }

        [HttpPost]
        public IActionResult AddProduto(Produto produto)
        {
            Produto retorno;
            try
            {
                Categoria categ = new Categoria { Nome = "PRODUTO TESTE" };
                var ret = _uow.ICategoriaRepository.Add(categ);
                _uow.Save();

                produto.Categoria = categ;
                retorno = _uow.IProdutoRepository.Add(produto);
                _uow.Save();

                return Ok(retorno);
            } catch
            {
                _uow.Dispose();
            }
            return Ok(null);
        }
    }
}
