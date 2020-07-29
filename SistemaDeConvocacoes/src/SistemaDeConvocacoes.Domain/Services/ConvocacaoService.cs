using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class ConvocacaoService : IConvocacaoService
    {
        private readonly IConvocacaoRepository _convocacaoRepository;
        private readonly IPasswordGeneratorService _passwordGenerator;

        public ConvocacaoService(IConvocacaoRepository convocacaoRepository, IPasswordGeneratorService passwordGenerator)
        {
            _convocacaoRepository = convocacaoRepository;
            _passwordGenerator = passwordGenerator;
        }

        public void Dispose()
        {
            _convocacaoRepository.Dispose();
        }

        public async Task<Convocacao> AddAsync(Convocacao obj)
        {
            return await _convocacaoRepository.AddAsync(obj);
        }

        public async Task<Convocacao> GetByIdAsync(Guid id)
        {
            return await _convocacaoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Convocacao>> GetAllAsync()
        {
            return await _convocacaoRepository.GetAllAsync();
        }

        public async Task<Convocacao> UpdateAsync(Convocacao obj)
        {
            return await _convocacaoRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _convocacaoRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Convocacao>> SearchAsync(Expression<Func<Convocacao, bool>> predicate)
        {
            return await _convocacaoRepository.SearchAsync(predicate);
        }

        public async Task<string> GeneratePasswordAsync()
        {
            return await _passwordGenerator.GetPassword();
        }

        public async Task<Convocacao> GetOneAsync(Expression<Func<Convocacao, bool>> predicate)
        {
            return await _convocacaoRepository.GetOneAsync(predicate);
        }

        public IEnumerable<Convocacao> MontarListaDeConvocados(IEnumerable<Convocacao> dadosConfirmados, IEnumerable<Convocacao> convocados)
        {
            throw new NotImplementedException();
        }
    }
}