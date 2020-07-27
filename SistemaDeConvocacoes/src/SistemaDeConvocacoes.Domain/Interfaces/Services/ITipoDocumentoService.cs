using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ITipoDocumentoService : IRepository<TipoDocumento>
    {
        IQueryable<TipoDocumento> GetAll();
        Task Add(TipoDocumento entity);
        Task Update(TipoDocumento entity);
        Task Delete(Guid id);
        IEnumerable<TipoDocumento> Search(Expression<Func<TipoDocumento, bool>> predicate);
        TipoDocumento GetOne(Expression<Func<TipoDocumento, bool>> predicate);
        int SaveChanges();
        void Dispose();
        TipoDocumento GetById(Guid id);
    }
}