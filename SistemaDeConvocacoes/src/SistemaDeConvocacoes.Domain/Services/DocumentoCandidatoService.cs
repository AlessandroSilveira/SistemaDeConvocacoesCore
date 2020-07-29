using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class DocumentoCandidatoService : IDocumentoCandidatoService
    {
        private readonly IDocumentoCandidatoRepository _documentoCandidatoRepository;

        public DocumentoCandidatoService(IDocumentoCandidatoRepository documentoCandidatoRepository)
        {
            _documentoCandidatoRepository = documentoCandidatoRepository;
        }
        
        public void Dispose()
        {
            _documentoCandidatoRepository.Dispose();
        }

        public async Task<DocumentoCandidato> AddAsync(DocumentoCandidato obj)
        {
            return await _documentoCandidatoRepository.AddAsync(obj);
        }

        public async Task<DocumentoCandidato> GetByIdAsync(Guid id)
        {
            return await _documentoCandidatoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<DocumentoCandidato>> GetAllAsync()
        {
            return await _documentoCandidatoRepository.GetAllAsync();
        }

        public async Task<DocumentoCandidato> UpdateAsync(DocumentoCandidato obj)
        {
            return await _documentoCandidatoRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _documentoCandidatoRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<DocumentoCandidato>> SearchAsync(Expression<Func<DocumentoCandidato, bool>> predicate)
        {
            return await _documentoCandidatoRepository.SearchAsync(predicate);
        }

        public async Task<DocumentoCandidato> GetOneAsync(Expression<Func<DocumentoCandidato, bool>> predicate)
        {
            return await _documentoCandidatoRepository.GetOneAsync(predicate);
        }
    }
}