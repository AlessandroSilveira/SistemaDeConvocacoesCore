using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IDocumentoCandidatoAppService : IDisposable
    {
        DocumentoCandidatoViewModel Add(DocumentoCandidatoViewModel obj);

        DocumentoCandidatoViewModel GetById(Guid id);

        IEnumerable<DocumentoCandidatoViewModel> GetAll();

        DocumentoCandidatoViewModel Update(DocumentoCandidatoViewModel obj);

        void Remove(Guid id);

        IEnumerable<DocumentoCandidatoViewModel> Search(Expression<Func<DocumentoCandidato, bool>> predicate);

        DocumentoCandidatoViewModel GetOne(Expression<Func<DocumentoCandidato, bool>> predicate);

        List<ListaDocumentosViewModel> MontarListaDeDocumentosDoCandidatos(IEnumerable<DocumentoCandidatoViewModel> documentos, IEnumerable<ConvocadoViewModel> dadosCandidatos);
    }
}