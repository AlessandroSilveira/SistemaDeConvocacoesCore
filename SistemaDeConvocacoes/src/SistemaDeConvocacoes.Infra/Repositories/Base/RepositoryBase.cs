using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using SistemaDeConvocacoes.Domain.Interfaces.Base;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories.Base
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> DbSet;
        protected ApplicationDbContext Context;

        public RepositoryBase(ApplicationDbContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public TEntity Add(TEntity obj)
        {
            Context.Set<TEntity>().Add(obj);
            Context.SaveChangesAsync();
            return obj;
        }

        public virtual TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual TEntity Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
             Context.SaveChangesAsync();
            return obj;
        }

        public virtual void Remove(Guid id)
        {
            var entity = Context.Set<TEntity>().FindAsync(id).Result;

            Context.Set<TEntity>().Remove(entity);
            Context.SaveChangesAsync();
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

        public TEntity GetOne(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate).FirstOrDefault();
        }
    }
}