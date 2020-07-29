using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDocumentacaoService : IDisposable
    {
        Task<Documentacao> AddAsync(Documentacao obj);
        Task<Documentacao> GetByIdAsync(Guid id);
        Task<IEnumerable<Documentacao>> GetAllAsync();
        Task<Documentacao> UpdateAsync(Documentacao obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Documentacao>> SearchAsync(Expression<Func<Documentacao, bool>> predicate);
        Task<Documentacao> GetOneAsync(Expression<Func<Documentacao, bool>> predicate);
    }
}