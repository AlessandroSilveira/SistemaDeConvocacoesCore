using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDocumentacaoService : IDisposable
    {
        Task<Documento> AddAsync(Documento obj);
        Task<Documento> GetByIdAsync(Guid id);
        Task<IEnumerable<Documento>> GetAllAsync();
        Task<Documento> UpdateAsync(Documento obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Documento>> SearchAsync(Expression<Func<Documento, bool>> predicate);
        Task<Documento> GetOneAsync(Expression<Func<Documento, bool>> predicate);
    }
}