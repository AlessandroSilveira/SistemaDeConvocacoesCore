using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ITipoDocumentoService : IDisposable
    {
        Task<TipoDocumento> AddAsync(TipoDocumento obj);
        Task<TipoDocumento> GetByIdAsync(Guid id);
        Task<IEnumerable<TipoDocumento>> GetAllAsync();
        Task<TipoDocumento> UpdateAsync(TipoDocumento obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<TipoDocumento>> SearchAsync(Expression<Func<TipoDocumento, bool>> predicate);
        Task<TipoDocumento> GetOneAsync(Expression<Func<TipoDocumento, bool>> predicate);
    }
}