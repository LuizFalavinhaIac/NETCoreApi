using ApiLoja.Models.Data;
using ApiLoja.Repositories.Interfaces;
using System;

namespace ApiLoja.Repositories
{
    public interface IUnitOfWork<T> : IDisposable where T : Entity
    {
        IProdutoRepository IProdutoRepository { get; }
        ICategoriaRepository ICategoriaRepository { get; }
        void Save();
    }
}
