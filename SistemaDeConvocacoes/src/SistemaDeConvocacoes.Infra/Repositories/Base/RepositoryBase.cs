using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaDeConvocacoes.Domain.Interfaces.Base;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        
        protected ApplicationDbContext Context;

        public RepositoryBase(ApplicationDbContext context)
        {
            Context = context;           
        }

        public async Task<TEntity> Add(TEntity obj)
        {
            Context.Set<TEntity>().Add(obj);            
            return obj;
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public async Task<TEntity> Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;            
            return obj;
        }

        public async Task Remove(Guid id)
        {
            var entity = Context.Set<TEntity>().FindAsync(id).Result;

            Context.Set<TEntity>().Remove(entity);
           
        }

        public async Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }
       

        public async Task Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<TEntity> GetOne(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).FirstOrDefault();
        }
    }
}