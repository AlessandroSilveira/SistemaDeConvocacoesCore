using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IAspNetUserRolesService : IDisposable
    {
        IQueryable<AspNetUserRoles> GetAll();
        Task Create(AspNetUserRoles entity);
        Task Update(int id, AspNetUserRoles entity);
        Task Delete(int id);
        IEnumerable<AspNetUserRoles> Search(Expression<Func<AspNetUserRoles, bool>> predicate);
        AspNetUserRoles GetOne(Expression<Func<AspNetUserRoles, bool>> predicate);
        int SaveChanges();
        void Dispose();
    }
}