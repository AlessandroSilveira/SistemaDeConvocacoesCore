using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IClienteAppService : IDisposable
    {
        Task<ClienteViewModel> AddAsync(ClienteViewModel obj);

        Task<ClienteViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<ClienteViewModel>> GetAllAsync();

        Task<ClienteViewModel> UpdateAsync(ClienteViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<ClienteViewModel>> SearchAsync(Expression<Func<Cliente, bool>> predicate);

        Task<ClienteViewModel> GetOneAsync(Expression<Func<Cliente, bool>> predicate);
    }
}