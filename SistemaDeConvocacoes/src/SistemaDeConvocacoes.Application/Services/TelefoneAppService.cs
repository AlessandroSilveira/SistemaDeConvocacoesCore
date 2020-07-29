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
    public class TelefoneAppService : ITelefoneAppService
    {
        private readonly ITelefoneService _telefoneService;
        private readonly IMapper _mapper;

        public TelefoneAppService(ITelefoneService telefoneService, IMapper mapper)
        {
            _telefoneService = telefoneService;
            _mapper = mapper;
        }

        public void DisposeAsync()
        {
            _telefoneService.DisposeAsync();
        }

        public TelefoneViewModel Add(TelefoneViewModel obj)
        {
            var telefone = _mapper.Map<TelefoneViewModel, Telefone>(obj);            
            _telefoneService.Add(telefone);            
            return obj;
        }

        public TelefoneViewModel GetById(Guid id)
        {
            return _mapper.Map<Telefone, TelefoneViewModel>(_telefoneService.GetById(id));
        }

        public IEnumerable<TelefoneViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Telefone>, IEnumerable<TelefoneViewModel>>(_telefoneService.GetAll());
        }

        public TelefoneViewModel Update(TelefoneViewModel obj)
        {           
            _telefoneService.Update(_mapper.Map<TelefoneViewModel, Telefone>(obj));           
            return obj;
        }

        public void Remove(Guid id)
        {           
            _telefoneService.Remove(id);            
        }

        public IEnumerable<TelefoneViewModel> Search(Expression<Func<Telefone, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Telefone>, IEnumerable<TelefoneViewModel>>(
                _telefoneService.Search(predicate));
        }

        public TelefoneViewModel GetOne(Expression<Func<Telefone, bool>> predicate)
        {
            return _mapper.Map<Telefone, TelefoneViewModel>(_telefoneService.GetOne(predicate));
        }
    }
}