using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IPrimeiroAcessoService : IDisposable
    {
        Task<PrimeiroAcesso> AddAsync(PrimeiroAcesso obj);
        Task<PrimeiroAcesso> GetByIdAsync(Guid id);
        Task<IEnumerable<PrimeiroAcesso>> GetAllAsync();
        Task<PrimeiroAcesso> UpdateAsync(PrimeiroAcesso obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<PrimeiroAcesso>> SearchAsync(Expression<Func<PrimeiroAcesso, bool>> predicate);
        Task<PrimeiroAcesso> GetOneAsync(Expression<Func<PrimeiroAcesso, bool>> predicate);
    }
}