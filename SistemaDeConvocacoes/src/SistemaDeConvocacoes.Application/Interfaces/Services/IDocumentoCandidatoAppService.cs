using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IDocumentoCandidatoAppService : IDisposable
    {
        Task<DocumentoCandidatoViewModel> AddAsync(DocumentoCandidatoViewModel obj);

        Task<DocumentoCandidatoViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<DocumentoCandidatoViewModel>> GetAllAsync();

        Task<DocumentoCandidatoViewModel> UpdateAsync(DocumentoCandidatoViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<DocumentoCandidatoViewModel>> SearchAsync(Expression<Func<DocumentoCandidato, bool>> predicate);

        Task<DocumentoCandidatoViewModel> GetOneAsync(Expression<Func<DocumentoCandidato, bool>> predicate);

        Task<List<ListaDocumentosViewModel>> MontarListaDeDocumentosDoCandidatos(IEnumerable<DocumentoCandidatoViewModel> documentos, IEnumerable<ConvocadoViewModel> dadosCandidatos);
    }
}