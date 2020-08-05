using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Application.Services
{
    public class DocumentacaoAppService : IDocumentacaoAppService
    {
        private readonly IDocumentacaoService _documentacaoService;
        private readonly IMapper _mapper;

        public DocumentacaoAppService(IDocumentacaoService documentacaoService, IMapper mapper)
        {
            _documentacaoService = documentacaoService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _documentacaoService.Dispose();
        }

        public async Task<DocumentacaoViewModel> AddAsync(DocumentacaoViewModel obj)
        {
            var documento = _mapper.Map<DocumentacaoViewModel, Documento>(obj);           
            await _documentacaoService.AddAsync(documento);           
            return obj;
        }

        public async Task<DocumentacaoViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Documento, DocumentacaoViewModel>(await _documentacaoService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<DocumentacaoViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Documento>, IEnumerable<DocumentacaoViewModel>>(
                await _documentacaoService.GetAllAsync());
        }

        public async Task<DocumentacaoViewModel> UpdateAsync(DocumentacaoViewModel obj)
        {            
            await _documentacaoService.UpdateAsync(_mapper.Map<DocumentacaoViewModel, Documento>(obj));           
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {            
           await _documentacaoService.RemoveAsync(id);           
        }

        public async Task<IEnumerable<DocumentacaoViewModel>> SearchAsync(Expression<Func<Documento, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Documento>, IEnumerable<DocumentacaoViewModel>>(
                await _documentacaoService.SearchAsync(predicate));
        }

        public async Task<DocumentacaoViewModel> GetOneAsync(Expression<Func<Documento, bool>> predicate)
        {
            return _mapper.Map<Documento, DocumentacaoViewModel>(await _documentacaoService.GetOneAsync(predicate));
        }       
    }
}