using ApiLoja.Data;
using ApiLoja.Models.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiLoja.Repositories.Generics
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly DatabaseContext _context;
        protected readonly DbSet<TEntity> _DbSet;

        public GenericRepository(DatabaseContext context)
        {
            _context = context;
            _DbSet = _context.Set<TEntity>();
        }

        public List<TEntity> GetAll()
        {
            return _DbSet.ToList();
        }

        public TEntity Get(int id)
        {
            return _DbSet.Find(id);
        }

        public TEntity Add(TEntity entity)
        {
            _DbSet.Add(entity);
            return entity;
        }

        public void Update(TEntity entity)
        {
            _DbSet.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _DbSet.Remove(entity);
        }

    }
}
