using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IClienteService : IDisposable
    {
        Task<Cliente> AddAsync(Cliente obj);
        Task<Cliente> GetByIdAsync(Guid id);
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task<Cliente> UpdateAsync(Cliente obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Cliente>> SearchAsync(Expression<Func<Cliente, bool>> predicate);
        Task<Cliente> GetOneAsync(Expression<Func<Cliente, bool>> predicate);
    }
}