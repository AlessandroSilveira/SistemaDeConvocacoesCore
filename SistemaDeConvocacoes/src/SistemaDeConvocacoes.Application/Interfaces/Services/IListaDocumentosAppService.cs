using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Application.ViewModels;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IListaDocumentosAppService :IDisposable
    {
        IQueryable<ListaDocumentosViewModel> GetAll();
        Task Create(ListaDocumentosViewModel entity);
        Task Update(int id, ListaDocumentosViewModel entity);
        Task Delete(ListaDocumentosViewModel entity);
        IEnumerable<ListaDocumentosViewModel> Search(Expression<Func<ListaDocumentosViewModel, bool>> predicate);
        int SaveChanges();
        void Dispose();
        ListaDocumentosViewModel GetOne(Expression<Func<ListaDocumentosViewModel, bool>> predicate);
    }
}