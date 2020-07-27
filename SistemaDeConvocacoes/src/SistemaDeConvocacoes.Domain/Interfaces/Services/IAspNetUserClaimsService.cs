using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IAspNetUserClaimsService : IDisposable
    {
        IQueryable<AspNetUserClaims> GetAll();
        Task Create(AspNetUserClaims entity);
        Task Update(int id, AspNetUserClaims entity);
        Task Delete(int id);
        IEnumerable<AspNetUserClaims> Search(Expression<Func<AspNetUserClaims, bool>> predicate);
        AspNetUserClaims GetOne(Expression<Func<AspNetUserClaims, bool>> predicate);
        int SaveChanges();
        void Dispose();
    }
}