using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface ITipoDocumentoAppService : IDisposable
    {
        TipoDocumentoViewModel Add(TipoDocumentoViewModel obj);

        TipoDocumentoViewModel GetById(Guid id);

        IEnumerable<TipoDocumentoViewModel> GetAll();

        TipoDocumentoViewModel Update(TipoDocumentoViewModel obj);

        void Remove(Guid id);

        IEnumerable<TipoDocumentoViewModel> Search(Expression<Func<TipoDocumento, bool>> predicate);

        TipoDocumentoViewModel GetOne(Expression<Func<TipoDocumento, bool>> predicate);
    }
}