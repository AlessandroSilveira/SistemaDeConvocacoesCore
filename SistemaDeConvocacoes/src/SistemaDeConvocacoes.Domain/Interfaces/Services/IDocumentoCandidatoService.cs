using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDocumentoCandidatoService : IDisposable
    {
        Task<DocumentoCandidato> AddAsync(DocumentoCandidato obj);
        Task<DocumentoCandidato> GetByIdAsync(Guid id);
        Task<IEnumerable<DocumentoCandidato>> GetAllAsync();
        Task<DocumentoCandidato> UpdateAsync(DocumentoCandidato obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<DocumentoCandidato>> SearchAsync(Expression<Func<DocumentoCandidato, bool>> predicate);
        Task<DocumentoCandidato> GetOneAsync(Expression<Func<DocumentoCandidato, bool>> predicate);
    }
}