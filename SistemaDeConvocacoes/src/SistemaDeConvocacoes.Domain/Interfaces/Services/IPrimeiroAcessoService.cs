using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IPrimeiroAcessoService  : IDisposable
    {
        IQueryable<PrimeiroAcesso> GetAll();
        Task Add(PrimeiroAcesso entity);
        Task Update(PrimeiroAcesso entity);
        Task Delete(Guid id);
        IEnumerable<PrimeiroAcesso> Search(Expression<Func<PrimeiroAcesso, bool>> predicate);
        PrimeiroAcesso GetOne(Expression<Func<PrimeiroAcesso, bool>> predicate);
        int SaveChanges();
        void Dispose();
        PrimeiroAcesso GetById(Guid id);
    }
}