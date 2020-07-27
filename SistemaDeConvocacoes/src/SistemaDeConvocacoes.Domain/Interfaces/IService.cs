using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Domain.Interfaces
{
    public interface IService<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task Create(TEntity entity);
        Task Update(int id, TEntity entity);
        Task Delete(int id);
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
        TEntity GetOne(Expression<Func<TEntity, bool>> predicate);
    }
}