using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IConvocacoesAppService : IDisposable
    {
        IQueryable<ConvocacoesViewModel> GetAll();
        Task Create(ConvocacoesViewModel entity);
        Task Update(int id, ConvocacoesViewModel entity);
        Task Delete(ConvocacoesViewModel entity);
        IEnumerable<ConvocacoesViewModel> Search(Expression<Func<ConvocacoesViewModel, bool>> predicate);
        int SaveChanges();
        void Dispose();
        ConvocacoesViewModel GetOne(Expression<Func<ConvocacoesViewModel, bool>> predicate);
    }
}