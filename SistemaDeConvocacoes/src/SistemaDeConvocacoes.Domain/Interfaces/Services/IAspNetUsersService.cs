using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IAspNetUsersService : IDisposable
    {
        IQueryable<AspNetUsers> GetAll();
        Task Create(AspNetUsers entity);
        Task Update(int id, AspNetUsers entity);
        Task Delete(int id);
        IEnumerable<AspNetUsers> Search(Expression<Func<AspNetUsers, bool>> predicate);
        AspNetUsers GetOne(Expression<Func<AspNetUsers, bool>> predicate);
        int SaveChanges();
        void Dispose();
    }
}