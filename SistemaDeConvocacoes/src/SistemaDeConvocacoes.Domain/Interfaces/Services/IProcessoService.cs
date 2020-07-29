using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IProcessoService : IDisposable
    {
        Task<Processo> AddAsync(Processo obj);
        Task<Processo> GetByIdAsync(Guid id);
        Task<IEnumerable<Processo>> GetAllAsync();
        Task<Processo> UpdateAsync(Processo obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Processo>> SearchAsync(Expression<Func<Processo, bool>> predicate);
        Task<Processo> GetOneAsync(Expression<Func<Processo, bool>> predicate);
    }
}