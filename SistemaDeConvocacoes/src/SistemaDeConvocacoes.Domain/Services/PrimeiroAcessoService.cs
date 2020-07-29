using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class PrimeiroAcessoService : IPrimeiroAcessoService
    {
        private readonly IPrimeiroAcessoRepository _primeiroAcessoRepository;

        public PrimeiroAcessoService(IPrimeiroAcessoRepository primeiroAcessoRepository)
        {
            _primeiroAcessoRepository = primeiroAcessoRepository;
        }

        public void Dispose()
        {
            _primeiroAcessoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<PrimeiroAcesso> AddAsync(PrimeiroAcesso obj)
        {
            return await _primeiroAcessoRepository.AddAsync(obj);
        }

        public async Task<PrimeiroAcesso> GetByIdAsync(Guid id)
        {
            return await _primeiroAcessoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<PrimeiroAcesso>> GetAllAsync()
        {
            return await _primeiroAcessoRepository.GetAllAsync();
        }

        public async Task<PrimeiroAcesso> UpdateAsync(PrimeiroAcesso obj)
        {
            return await _primeiroAcessoRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _primeiroAcessoRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<PrimeiroAcesso>> SearchAsync(Expression<Func<PrimeiroAcesso, bool>> predicate)
        {
            return await _primeiroAcessoRepository.SearchAsync(predicate);
        }

        public async Task<PrimeiroAcesso> GetOneAsync(Expression<Func<PrimeiroAcesso, bool>> predicate)
        {
            return await _primeiroAcessoRepository.GetOneAsync(predicate);
        }
    }
}