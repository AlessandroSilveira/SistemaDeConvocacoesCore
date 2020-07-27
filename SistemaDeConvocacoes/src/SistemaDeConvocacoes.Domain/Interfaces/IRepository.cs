using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Domain.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task Create(TEntity entity);
        Task Update(int id, TEntity entity);
        Task Delete(TEntity entity);
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
        void Dispose();
        TEntity GetOne(Expression<Func<TEntity, bool>> predicate);
    }
}