using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using SisConv.Application.Services;
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

        public PrimeiroAcessoViewModel Add(PrimeiroAcessoViewModel obj)
        {
            var primeiroAcesso = _mapper.Map<PrimeiroAcessoViewModel, PrimeiroAcesso>(obj);           
            _primeiroAcessoService.Add(primeiroAcesso);            
            return obj;
        }

        public PrimeiroAcessoViewModel GetById(Guid id)
        {
            return _mapper.Map<PrimeiroAcesso, PrimeiroAcessoViewModel>(_primeiroAcessoService.GetById(id));
        }

        public IEnumerable<PrimeiroAcessoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<PrimeiroAcesso>, IEnumerable<PrimeiroAcessoViewModel>>(_primeiroAcessoService
                .GetAll());
        }

        public PrimeiroAcessoViewModel Update(PrimeiroAcessoViewModel obj)
        {            
            _primeiroAcessoService.Update(_mapper.Map<PrimeiroAcessoViewModel, PrimeiroAcesso>(obj));            
            return obj;
        }

        public void Remove(Guid id)
        {            
            _primeiroAcessoService.Delete(id);            
        }

        public IEnumerable<PrimeiroAcessoViewModel> Search(Expression<Func<PrimeiroAcesso, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<PrimeiroAcesso>, IEnumerable<PrimeiroAcessoViewModel>>(
                _primeiroAcessoService.Search(predicate));
        }

        public PrimeiroAcessoViewModel GetOne(Expression<Func<PrimeiroAcesso, bool>> predicate)
        {
            return _mapper.Map<PrimeiroAcesso, PrimeiroAcessoViewModel>(_primeiroAcessoService.GetOne(predicate));
        }
    }
}