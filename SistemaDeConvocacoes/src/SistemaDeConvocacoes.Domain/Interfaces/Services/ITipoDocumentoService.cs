using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ITipoDocumentoService : IDisposable
    {
        TipoDocumento Add(TipoDocumento obj);
        TipoDocumento GetById(Guid id);
        IEnumerable<TipoDocumento> GetAll();
        TipoDocumento Update(TipoDocumento obj);
        void Remove(Guid id);
        IEnumerable<TipoDocumento> Search(Expression<Func<TipoDocumento, bool>> predicate);
        TipoDocumento GetOne(Expression<Func<TipoDocumento, bool>> predicate);
    }
}