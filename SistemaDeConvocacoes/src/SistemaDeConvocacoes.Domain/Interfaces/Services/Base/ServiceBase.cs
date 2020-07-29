using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Interfaces.Base;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services.Base
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
      
        public async Task Add(TEntity obj)
        {
           await _repositoryBase.AddAsync(obj);
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _repositoryBase.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repositoryBase.GetAllAsync();
        }

        public async Task UpdateAsync(TEntity obj)
        {
            await  _repositoryBase.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid obj)
        {
            await _repositoryBase.RemoveAsync(obj);
        }

      

        public async Task<IEnumerable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repositoryBase.SearchAsync(predicate);
        }

        public async Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _repositoryBase.GetOneAsync(predicate);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

       
    }
}