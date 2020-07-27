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
    public class TipoDocumentoAppService : ITipoDocumentoAppService
    {
        private readonly ITipoDocumentoService _tipoDocumentoService;
        private readonly IMapper _mapper;

        public TipoDocumentoAppService(ITipoDocumentoService tipoDocumentoService, IMapper mapper)
        {
            _tipoDocumentoService = tipoDocumentoService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _tipoDocumentoService.Dispose();
        }

        public TipoDocumentoViewModel Add(TipoDocumentoViewModel obj)
        {
            var dados = _mapper.Map<TipoDocumentoViewModel, TipoDocumento>(obj);
            
            _tipoDocumentoService.Add(dados);
            
            return obj;
        }

        public TipoDocumentoViewModel GetById(Guid id)
        {
            return _mapper.Map<TipoDocumento, TipoDocumentoViewModel>(_tipoDocumentoService.GetById(id));
        }

        public IEnumerable<TipoDocumentoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TipoDocumento>, IEnumerable<TipoDocumentoViewModel>>(_tipoDocumentoService.GetAll());
        }

        public TipoDocumentoViewModel Update(TipoDocumentoViewModel obj)
        {
           
            _tipoDocumentoService.Update(_mapper.Map<TipoDocumentoViewModel, TipoDocumento>(obj));
            
            return obj;
        }

        public void Remove(Guid id)
        {            
            _tipoDocumentoService.Remove(id);            
        }

        public IEnumerable<TipoDocumentoViewModel> Search(Expression<Func<TipoDocumento, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<TipoDocumento>, IEnumerable<TipoDocumentoViewModel>>(
                _tipoDocumentoService.Search(predicate));
        }

        public TipoDocumentoViewModel GetOne(Expression<Func<TipoDocumento, bool>> predicate)
        {
            return _mapper.Map<TipoDocumento, TipoDocumentoViewModel>(
                _tipoDocumentoService.GetOne(predicate));
        }
    }
}