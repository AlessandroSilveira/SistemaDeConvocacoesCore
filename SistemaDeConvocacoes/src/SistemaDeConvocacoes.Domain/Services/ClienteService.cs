using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<Cliente> AddAsync(Cliente obj)
        {
            return await _clienteRepository.AddAsync(obj);
        }

        public async Task<Cliente> GetByIdAsync(Guid id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }

        public async Task<Cliente> UpdateAsync(Cliente obj)
        {
            return await _clienteRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _clienteRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Cliente>> SearchAsync(Expression<Func<Cliente, bool>> predicate)
        {
            return await _clienteRepository.SearchAsync(predicate);
        }

        public async Task<Cliente> GetOneAsync(Expression<Func<Cliente, bool>> predicate)
        {
            return await _clienteRepository.GetOneAsync(predicate);
        }
    }
}