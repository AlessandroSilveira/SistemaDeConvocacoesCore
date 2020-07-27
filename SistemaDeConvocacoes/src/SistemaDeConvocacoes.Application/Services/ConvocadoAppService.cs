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
        private readonly IConvocadosService _convocadoService;
        private readonly IMapper _mapper;

        public ConvocadoAppService(IConvocadosService convocadoService, IMapper mapper)
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
            var convocado = _mapper.Map<ConvocadoViewModel, Convocados>(obj);
            _convocadoService.Add(convocado);
            return obj;
        }

        public ConvocadoViewModel GetById(Guid id)
        {
            return _mapper.Map<Convocados, ConvocadoViewModel>(_convocadoService.GetById(id));
        }

        public IEnumerable<ConvocadoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Convocados>, IEnumerable<ConvocadoViewModel>>(_convocadoService.GetAll());
        }

        public ConvocadoViewModel Update(ConvocadoViewModel obj)
        {
            _convocadoService.Update(_mapper.Map<ConvocadoViewModel, Convocados>(obj));
            return obj;
        }

        public void Remove(Guid id)
        {
            _convocadoService.Delete(id);
        }

        public IEnumerable<ConvocadoViewModel> Search(Expression<Func<Convocados, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Convocados>, IEnumerable<ConvocadoViewModel>>(
                _convocadoService.Search(predicate));
        }

        public bool VerificaSeHaSobrenome(string nome)
        {
            return _convocadoService.VerificaSeHaSobrenome(nome);
        }

        public ConvocadoViewModel GetOne(Expression<Func<Convocados, bool>> predicate)
        {
            return _mapper.Map<Convocados, ConvocadoViewModel>(_convocadoService.GetOne(predicate));
        }
    }
}