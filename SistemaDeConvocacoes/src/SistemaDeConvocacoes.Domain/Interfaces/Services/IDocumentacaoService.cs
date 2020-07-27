using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDocumentacaoService : IDisposable
    {
        Documentacao Add(Documentacao obj);
        Documentacao GetById(Guid id);
        IEnumerable<Documentacao> GetAll();
        Documentacao Update(Documentacao obj);
        void Remove(Guid id);
        IEnumerable<Documentacao> Search(Expression<Func<Documentacao, bool>> predicate);
        Documentacao GetOne(Expression<Func<Documentacao, bool>> predicate);
    }
}