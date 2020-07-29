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

        public async Task<Cliente> Add(Cliente obj)
        {
            return await _clienteRepository.AddAsync(obj);
        }

        public async Task<Cliente> GetById(Guid id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Cliente>> GetAll()
        {
            return await _clienteRepository.GetAllAsync();
        }

        public async Task<Cliente> Update(Cliente obj)
        {
            return await _clienteRepository.UpdateAsync(obj);
        }

        public async Task Remove(Guid id)
        {
            await _clienteRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Cliente>> Search(Expression<Func<Cliente, bool>> predicate)
        {
            return await _clienteRepository.SearchAsync(predicate);
        }

        public async Task<Cliente> GetOne(Expression<Func<Cliente, bool>> predicate)
        {
            return await _clienteRepository.GetOneAsync(predicate);
        }
    }
}