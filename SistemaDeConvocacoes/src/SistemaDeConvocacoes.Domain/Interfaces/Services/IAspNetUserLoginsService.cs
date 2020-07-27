using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IAspNetUserLoginsService
    {
        IQueryable<AspNetUserLogins> GetAll();
        Task Create(AspNetUserLogins entity);
        Task Update(int id, AspNetUserLogins entity);
        Task Delete(int id);
        IEnumerable<AspNetUserLogins> Search(Expression<Func<AspNetUserLogins, bool>> predicate);
        AspNetUserLogins GetOne(Expression<Func<AspNetUserLogins, bool>> predicate);
        int SaveChanges();
        void Dispose();
    }
}