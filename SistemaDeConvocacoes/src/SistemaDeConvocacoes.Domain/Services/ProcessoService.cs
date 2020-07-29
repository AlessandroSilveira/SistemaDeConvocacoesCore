using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class ProcessoService : IProcessoService
    {
        private readonly IProcessoRepository _processoRepository;

        public ProcessoService(IProcessoRepository processoRepository)
        {
            _processoRepository = processoRepository;
        }

        public void Dispose()
        {
            _processoRepository.Dispose();
        }

        public async Task<Processo> AddAsync(Processo obj)
        {
            return await _processoRepository.AddAsync(obj);
        }

        public async Task<Processo> GetByIdAsync(Guid id)
        {
            return await _processoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Processo>> GetAllAsync()
        {
            return await _processoRepository.GetAllAsync();
        }

        public async Task<Processo> UpdateAsync(Processo obj)
        {
            return await _processoRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
           await _processoRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Processo>> SearchAsync(Expression<Func<Processo, bool>> predicate)
        {
            return await _processoRepository.SearchAsync(predicate);
        }

        public async Task<Processo> GetOneAsync(Expression<Func<Processo, bool>> predicate)
        {
            return await _processoRepository.GetOneAsync(predicate);
        }
    }
}