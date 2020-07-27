using AutoMapper;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Services
{
    public class ConvocadoAppService : IConvocadoAppService
    {
        private readonly IConvocadoService _convocadoService;
        private readonly IMapper _mapper;

        public ConvocadoAppService(IConvocadoService convocadoService, IMapper mapper)
        {
            _convocadoService = convocadoService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _convocadoService.Dispose();
        }

        public ConvocadoViewModel Add(ConvocadoViewModel obj)
        {
            var convocado = _mapper.Map<ConvocadoViewModel, Convocado>(obj);
            _convocadoService.Add(convocado);
            return obj;
        }

        public ConvocadoViewModel GetById(Guid id)
        {
            return _mapper.Map<Convocado, ConvocadoViewModel>(_convocadoService.GetById(id));
        }

        public IEnumerable<ConvocadoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Convocado>, IEnumerable<ConvocadoViewModel>>(_convocadoService.GetAll());
        }

        public ConvocadoViewModel Update(ConvocadoViewModel obj)
        {
            _convocadoService.Update(_mapper.Map<ConvocadoViewModel, Convocado>(obj));
            return obj;
        }

        public void Remove(Guid id)
        {
            _convocadoService.Remove(id);
        }

        public IEnumerable<ConvocadoViewModel> Search(Expression<Func<Convocado, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Convocado>, IEnumerable<ConvocadoViewModel>>(
                _convocadoService.Search(predicate));
        }

        public bool VerificaSeHaSobrenome(string nome)
        {
            return _convocadoService.VerificaSeHaSobrenome(nome);
        }

        public ConvocadoViewModel GetOne(Expression<Func<Convocado, bool>> predicate)
        {
            return _mapper.Map<Convocado, ConvocadoViewModel>(_convocadoService.GetOne(predicate));
        }
    }
}