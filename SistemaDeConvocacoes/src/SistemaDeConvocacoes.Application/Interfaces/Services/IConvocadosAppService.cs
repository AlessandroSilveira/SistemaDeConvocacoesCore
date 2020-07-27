using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Application.ViewModels;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IConvocadosAppService : IDisposable
    {
        IQueryable<ConvocadoViewModel> GetAll();
        Task Create(ConvocadoViewModel entity);
        Task Update(int id, ConvocadoViewModel entity);
        Task Delete(ConvocadoViewModel entity);
        IEnumerable<ConvocadoViewModel> Search(Expression<Func<ConvocadoViewModel, bool>> predicate);
        int SaveChanges();
        void Dispose();
        ConvocadoViewModel GetOne(Expression<Func<ConvocadoViewModel, bool>> predicate);
    }
}