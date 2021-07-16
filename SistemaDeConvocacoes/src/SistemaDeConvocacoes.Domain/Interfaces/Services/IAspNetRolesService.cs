using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IAspNetRolesService : IDisposable
    {
        IQueryable<AspNetRoles> GetAll();
        Task Create(AspNetRoles entity);
        Task Update(int id, AspNetRoles entity);
        Task Delete(int id);
        IEnumerable<AspNetRoles> Search(Expression<Func<AspNetRoles, bool>> predicate);
        AspNetRoles GetOne(Expression<Func<AspNetRoles, bool>> predicate);
        int SaveChanges();
       
       
    }
}