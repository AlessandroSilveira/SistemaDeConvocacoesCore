using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IDocumentacaoAppService : IDisposable
    {
        Task<DocumentacaoViewModel> AddAsync(DocumentacaoViewModel obj);

        Task<DocumentacaoViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<DocumentacaoViewModel>> GetAllAsync();

        Task<DocumentacaoViewModel> UpdateAsync(DocumentacaoViewModel obj);

        Task RemoveAsync(Guid id);


        Task<IEnumerable<DocumentacaoViewModel>> SearchAsync(Expression<Func<Documentacao, bool>> predicate);

       
    }
}