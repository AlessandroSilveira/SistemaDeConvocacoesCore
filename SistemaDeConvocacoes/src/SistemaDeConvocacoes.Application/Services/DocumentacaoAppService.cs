using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public DocumentacaoViewModel Add(DocumentacaoViewModel obj)
        {
            var documento = _mapper.Map<DocumentacaoViewModel, Documentacao>(obj);           
            _documentacaoService.Add(documento);           
            return obj;
        }

        public DocumentacaoViewModel GetById(Guid id)
        {
            return _mapper.Map<Documentacao, DocumentacaoViewModel>(_documentacaoService.GetById(id));
        }

        public IEnumerable<DocumentacaoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Documentacao>, IEnumerable<DocumentacaoViewModel>>(
                _documentacaoService.GetAll());
        }

        public DocumentacaoViewModel Update(DocumentacaoViewModel obj)
        {            
            _documentacaoService.Update(_mapper.Map<DocumentacaoViewModel, Documentacao>(obj));           
            return obj;
        }

        public void Remove(Guid id)
        {            
            _documentacaoService.Remove(id);           
        }

        public IEnumerable<DocumentacaoViewModel> Search(Expression<Func<Documentacao, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Documentacao>, IEnumerable<DocumentacaoViewModel>>(
                _documentacaoService.Search(predicate));
        }

        public DocumentacaoViewModel GetOne(Expression<Func<Documentacao, bool>> predicate)
        {
            return _mapper.Map<Documentacao, DocumentacaoViewModel>(_documentacaoService.GetOne(predicate));
        }
    }
}