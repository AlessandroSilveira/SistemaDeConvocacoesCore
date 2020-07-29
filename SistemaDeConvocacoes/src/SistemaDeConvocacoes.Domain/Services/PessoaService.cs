using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void Dispose()
        {
            _pessoaRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<Pessoa> AddAsync(Pessoa obj)
        {
            return await _pessoaRepository.AddAsync(obj);
        }

        public async Task<Pessoa> GetByIdAsync(Guid id)
        {
            return await _pessoaRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Pessoa>> GetAllAsync()
        {
            return await _pessoaRepository.GetAllAsync();
        }

        public async Task<Pessoa> UpdateAsync(Pessoa obj)
        {
            return await _pessoaRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _pessoaRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Pessoa>> SearchAsync(Expression<Func<Pessoa, bool>> predicate)
        {
            return await _pessoaRepository.SearchAsync(predicate);
        }

        public async Task<Pessoa> GetOneAsync(Expression<Func<Pessoa, bool>> predicate)
        {
            return await _pessoaRepository.GetOneAsync(predicate);
        }
    }
}