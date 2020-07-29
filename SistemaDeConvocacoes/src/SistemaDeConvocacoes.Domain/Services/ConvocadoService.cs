using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class ConvocadoService : IConvocadoService
    {
        private readonly IConvocadoRepository _convocadoRepository;


        public ConvocadoService(IConvocadoRepository convocadoRepository)
        {
            _convocadoRepository = convocadoRepository;
        }

        public void Dispose()
        {
            _convocadoRepository.Dispose();
        }

        public async Task<Convocado> AddAsync(Convocado obj)
        {
            return await _convocadoRepository.AddAsync(obj);
        }

        public async Task<Convocado> GetByIdAsync(Guid id)
        {
            return await _convocadoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Convocado>> GetAllAsync()
        {
            return await _convocadoRepository.GetAllAsync();
        }

        public async Task<Convocado> UpdateAsync(Convocado obj)
        {
            return await _convocadoRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _convocadoRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Convocado>> SearchAsync(Expression<Func<Convocado, bool>> predicate)
        {
            return await _convocadoRepository.SearchAsync(predicate);
        }

        public async Task<bool> VerificaSeHaSobrenome(string nome)
        {
            return nome.Trim().Split(' ').Length > 1;
        }

        public async Task<Convocado> GetOneAsync(Expression<Func<Convocado, bool>> predicate)
        {
            return await _convocadoRepository.GetOneAsync(predicate);
        }
    }
}