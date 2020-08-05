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

        public async Task<Documento> AddAsync(Documento obj)
        {
            return await _documentacaoRepository.AddAsync(obj);
        }

        public async Task<Documento> GetByIdAsync(Guid id)
        {
            return await _documentacaoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Documento>> GetAllAsync()
        {
            return await _documentacaoRepository.GetAllAsync();
        }

        public async Task<Documento> UpdateAsync(Documento obj)
        {
            return await _documentacaoRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _documentacaoRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Documento>> SearchAsync(Expression<Func<Documento, bool>> predicate)
        {
            return await _documentacaoRepository.SearchAsync(predicate);
        }

        public async Task<Documento> GetOneAsync(Expression<Func<Documento, bool>> predicate)
        {
            return await _documentacaoRepository.GetOneAsync(predicate);
        }
    }
}