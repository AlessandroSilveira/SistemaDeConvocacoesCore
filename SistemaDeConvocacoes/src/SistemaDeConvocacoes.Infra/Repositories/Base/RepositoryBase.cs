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

        public async Task<TEntity> AddAsync(TEntity obj)
        {
            await Context.Set<TEntity>().AddAsync(obj);
            await Context.SaveChangesAsync();
            return obj;
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return Context.Set<TEntity>().ToList();
        }

        public async Task<TEntity> UpdateAsync(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;            
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
            var entity = Context.Set<TEntity>().FindAsync(id).Result;
            Context.Set<TEntity>().Remove(entity);
            await Context.SaveChangesAsync();

        }

        public async Task<IEnumerable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }
       

        public async Task Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate).FirstOrDefault();
        }
    }
}