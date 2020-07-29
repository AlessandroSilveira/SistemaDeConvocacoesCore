using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ICargoService : IDisposable
    {
        Task<Cargo> AddAsync(Cargo obj);
        Task<Cargo> GetByIdAsync(Guid id);
        Task<IEnumerable<Cargo>> GetAllAsync();
        Task<Cargo> UpdateAsync(Cargo obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Cargo>> SearchAsync(Expression<Func<Cargo, bool>> predicate);
        Task<Cargo> GetOneAsync(Expression<Func<Cargo, bool>> predicate);
    }
}