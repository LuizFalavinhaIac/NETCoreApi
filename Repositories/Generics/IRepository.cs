using ApiLoja.Models.Data;
using System.Collections.Generic;

namespace ApiLoja.Repositories
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        List<TEntity> GetAll();
        TEntity Get(int id);
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
