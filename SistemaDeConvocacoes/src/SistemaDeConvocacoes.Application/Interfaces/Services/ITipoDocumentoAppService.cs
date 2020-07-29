using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface ITipoDocumentoAppService : IDisposable
    {
        Task<TipoDocumentoViewModel> AddAsync(TipoDocumentoViewModel obj);

        Task<TipoDocumentoViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<TipoDocumentoViewModel>> GetAllAsync();

        Task<TipoDocumentoViewModel> UpdateAsync(TipoDocumentoViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<TipoDocumentoViewModel>> SearchAsync(Expression<Func<TipoDocumento, bool>> predicate);

        Task<TipoDocumentoViewModel> GetOneAsync(Expression<Func<TipoDocumento, bool>> predicate);
    }
}