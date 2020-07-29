using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class TelefoneService : ITelefoneService
    {
        private readonly ITelefoneRepository _telefoneRepository;

        public TelefoneService(ITelefoneRepository telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }

        public void Dispose()
        {
            _telefoneRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<Telefone> AddAsync(Telefone obj)
        {
            return await _telefoneRepository.AddAsync(obj);
        }

        public async Task<Telefone> GetByIdAsync(Guid id)
        {
            return await _telefoneRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Telefone>> GetAllAsync()
        {
            return await _telefoneRepository.GetAllAsync();
        }

        public async Task<Telefone> UpdateAsync(Telefone obj)
        {
            return await _telefoneRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _telefoneRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Telefone>> SearchAsync(Expression<Func<Telefone, bool>> predicate)
        {
            return await  _telefoneRepository.SearchAsync(predicate);
        }

        public async Task<Telefone> GetOneAsync(Expression<Func<Telefone, bool>> predicate)
        {
            return await _telefoneRepository.GetOneAsync(predicate);
        }
    }
}