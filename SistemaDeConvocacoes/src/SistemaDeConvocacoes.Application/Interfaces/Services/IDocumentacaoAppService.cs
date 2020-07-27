using SistemaDeConvocacoes.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IDocumentacaoAppService : IDisposable
    {
        DocumentacaoViewModel Add(DocumentacaoViewModel obj);

        DocumentacaoViewModel GetById(Guid id);

        IEnumerable<DocumentacaoViewModel> GetAll();

        DocumentacaoViewModel Update(DocumentacaoViewModel obj);

        void Remove(Guid id);

        //IEnumerable<DocumentacaoViewModel> Search(Expression<Func<documentos, bool>> predicate);

        //DocumentacaoViewModel GetOne(Expression<Func<Documentacao, bool>> predicate);
    }
}