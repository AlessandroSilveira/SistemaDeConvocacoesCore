using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface ITelefoneAppService : IDisposable
    {
        Task<TelefoneViewModel> AddAsync(TelefoneViewModel obj);

        Task<TelefoneViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<TelefoneViewModel>> GetAllAsync();

        Task<TelefoneViewModel> UpdateAsync(TelefoneViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<TelefoneViewModel>> SearchAsync(Expression<Func<Telefone, bool>> predicate);

        Task<TelefoneViewModel> GetOneAsync(Expression<Func<Telefone, bool>> predicate);
    }
}