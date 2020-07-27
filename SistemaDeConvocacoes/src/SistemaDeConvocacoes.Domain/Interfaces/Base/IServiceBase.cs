using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Domain.Interfaces.Base
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(Guid obj);
        void Dispose();
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
        TEntity GetOne(Expression<Func<TEntity, bool>> predicate);
    }
}