using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ITelefoneService : IDisposable
    {
        Task<Telefone> AddAsync(Telefone obj);
        Task<Telefone> GetByIdAsync(Guid id);
        Task<IEnumerable<Telefone>> GetAllAsync();
        Task<Telefone> UpdateAsync(Telefone obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Telefone>> SearchAsync(Expression<Func<Telefone, bool>> predicate);
        Task<Telefone> GetOneAsync(Expression<Func<Telefone, bool>> predicate);
    }
}