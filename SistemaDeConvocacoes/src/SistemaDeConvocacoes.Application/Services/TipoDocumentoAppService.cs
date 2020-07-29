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

        public async Task<TipoDocumentoViewModel> AddAsync(TipoDocumentoViewModel obj)
        {
            var dados = _mapper.Map<TipoDocumentoViewModel, TipoDocumento>(obj);
            
            await _tipoDocumentoService.AddAsync(dados);
            
            return obj;
        }

        public async Task<TipoDocumentoViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<TipoDocumento, TipoDocumentoViewModel>(await _tipoDocumentoService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<TipoDocumentoViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<TipoDocumento>, IEnumerable<TipoDocumentoViewModel>>(await _tipoDocumentoService.GetAllAsync());
        }

        public async Task<TipoDocumentoViewModel> UpdateAsync(TipoDocumentoViewModel obj)
        {
           
           await _tipoDocumentoService.UpdateAsync(_mapper.Map<TipoDocumentoViewModel, TipoDocumento>(obj));
            
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {            
          await _tipoDocumentoService.RemoveAsync(id);            
        }

        public async Task<IEnumerable<TipoDocumentoViewModel>> SearchAsync(Expression<Func<TipoDocumento, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<TipoDocumento>, IEnumerable<TipoDocumentoViewModel>>(
                await _tipoDocumentoService.SearchAsync(predicate));
        }

        public async Task<TipoDocumentoViewModel> GetOneAsync(Expression<Func<TipoDocumento, bool>> predicate)
        {
            return _mapper.Map<TipoDocumento, TipoDocumentoViewModel>(
                await _tipoDocumentoService.GetOneAsync(predicate));
        }
    }
}