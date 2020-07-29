using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IClienteService : IDisposable
    {
        Task<Cliente> Add(Cliente obj);
        Task<Cliente> GetById(Guid id);
        Task<IEnumerable<Cliente>> GetAll();
        Task<Cliente> Update(Cliente obj);
        Task Remove(Guid id);
        Task<IEnumerable<Cliente>> Search(Expression<Func<Cliente, bool>> predicate);
        Task<Cliente> GetOne(Expression<Func<Cliente, bool>> predicate);
    }
}