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
    public class PrimeiroAcessoAppService : IPrimeiroAcessoAppService
    {
        private readonly IPrimeiroAcessoService _primeiroAcessoService;
        private readonly IMapper _mapper;

        public PrimeiroAcessoAppService(IPrimeiroAcessoService primeiroAcessoService, IMapper mapper)

        {
            _primeiroAcessoService = primeiroAcessoService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _primeiroAcessoService.Dispose();
        }

        public async Task<PrimeiroAcessoViewModel> AddAsync(PrimeiroAcessoViewModel obj)
        {
            var primeiroAcesso = _mapper.Map<PrimeiroAcessoViewModel, PrimeiroAcesso>(obj);           
            await _primeiroAcessoService.AddAsync(primeiroAcesso);            
            return obj;
        }

        public async Task<PrimeiroAcessoViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<PrimeiroAcesso, PrimeiroAcessoViewModel>(await _primeiroAcessoService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<PrimeiroAcessoViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<PrimeiroAcesso>, IEnumerable<PrimeiroAcessoViewModel>>(await _primeiroAcessoService
                .GetAllAsync());
        }

        public async Task<PrimeiroAcessoViewModel> UpdateAsync(PrimeiroAcessoViewModel obj)
        {            
           await  _primeiroAcessoService.UpdateAsync(_mapper.Map<PrimeiroAcessoViewModel, PrimeiroAcesso>(obj));            
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {            
            await _primeiroAcessoService.RemoveAsync(id);            
        }

        public async Task<IEnumerable<PrimeiroAcessoViewModel>> SearchAsync(Expression<Func<PrimeiroAcesso, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<PrimeiroAcesso>, IEnumerable<PrimeiroAcessoViewModel>>(
                await _primeiroAcessoService.SearchAsync(predicate));
        }

        public async Task<PrimeiroAcessoViewModel> GetOneAsync(Expression<Func<PrimeiroAcesso, bool>> predicate)
        {
            return _mapper.Map<PrimeiroAcesso, PrimeiroAcessoViewModel>(await _primeiroAcessoService.GetOneAsync(predicate));
        }
    }
}