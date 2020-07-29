using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class DocumentacaoService : IDocumentacaoService
    {
        private readonly IDocumentacaoRepository _documentacaoRepository;

        public DocumentacaoService(IDocumentacaoRepository documentacaoRepository)
        {
            _documentacaoRepository = documentacaoRepository;
        }

        public void Dispose()
        {
            _documentacaoRepository.Dispose();
        }

        public async Task<Documentacao> AddAsync(Documentacao obj)
        {
            return await _documentacaoRepository.AddAsync(obj);
        }

        public async Task<Documentacao> GetByIdAsync(Guid id)
        {
            return await _documentacaoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Documentacao>> GetAllAsync()
        {
            return await _documentacaoRepository.GetAllAsync();
        }

        public async Task<Documentacao> UpdateAsync(Documentacao obj)
        {
            return await _documentacaoRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _documentacaoRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Documentacao>> SearchAsync(Expression<Func<Documentacao, bool>> predicate)
        {
            return await _documentacaoRepository.SearchAsync(predicate);
        }

        public async Task<Documentacao> GetOneAsync(Expression<Func<Documentacao, bool>> predicate)
        {
            return await _documentacaoRepository.GetOneAsync(predicate);
        }
    }
}