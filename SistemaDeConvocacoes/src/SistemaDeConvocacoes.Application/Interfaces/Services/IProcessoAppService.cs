using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IProcessoAppService : IDisposable
    {
        Task<ProcessoViewModel> AddAsync(ProcessoViewModel obj);

        Task<ProcessoViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<ProcessoViewModel>> GetAllAsync();

        Task<ProcessoViewModel> UpdateAsync(ProcessoViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<ProcessoViewModel>> SearchAsync(Expression<Func<Processo, bool>> predicate);

        Task<ProcessoViewModel> GetOneAsync(Expression<Func<Processo, bool>> predicate);
    }
}