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
        Task<ClienteViewModel> Add(ClienteViewModel obj);

        Task<ClienteViewModel> GetById(Guid id);

        Task<IEnumerable<ClienteViewModel>> GetAll();

        Task<ClienteViewModel> Update(ClienteViewModel obj);

        Task Remove(Guid id);

        Task<IEnumerable<ClienteViewModel>> Search(Expression<Func<Cliente, bool>> predicate);

        Task<ClienteViewModel> GetOne(Expression<Func<Cliente, bool>> predicate);
    }
}