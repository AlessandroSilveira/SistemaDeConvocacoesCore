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
    public class DadosConvocadosAppService : IDadosConvocacaoAppService
    {
        private readonly IDadosConvocadosService _dadosConvocadosService;
        private readonly IMapper _mapper;

        public DadosConvocadosAppService(IDadosConvocadosService dadosConvocadosService, IMapper mapper)
        {
            _dadosConvocadosService = dadosConvocadosService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _dadosConvocadosService.Dispose();
        }

        public DadosConvocadosViewModel Add(DadosConvocadosViewModel obj)
        {
            var convocado = _mapper.Map<DadosConvocadosViewModel, Convocados>(obj);
            _dadosConvocadosService.Add(convocado);
            return obj;
        }

        public DadosConvocadosViewModel GetById(Guid id)
        {
            return _mapper.Map<Convocados, DadosConvocadosViewModel>(_dadosConvocadosService.GetById(id));
        }

        public IEnumerable<DadosConvocadosViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Convocados>, IEnumerable<DadosConvocadosViewModel>>(_dadosConvocadosService
                .GetAll());
        }

        public DadosConvocadosViewModel Update(DadosConvocadosViewModel obj)
        {
            _dadosConvocadosService.Update(_mapper.Map<DadosConvocadosViewModel, Convocados>(obj));
            return obj;
        }

        public void Remove(Guid id)
        {
            _dadosConvocadosService.Remove(id);
        }

        public IEnumerable<DadosConvocadosViewModel> Search(Expression<Func<Convocados, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Convocados>, IEnumerable<DadosConvocadosViewModel>>(
                _dadosConvocadosService.Search(predicate));
        }

        public void SalvarCandidatos(Guid id, string file)
        {
            _dadosConvocadosService.SalvarCandidatos(id, file);
        }

        public void SalvarCargos(Guid id, string file)
        {
            _dadosConvocadosService.SalvarCargos(id, file);
        }

        public DadosConvocadosViewModel GetOne(Expression<Func<Convocados, bool>> predicate)
        {
            return _mapper.Map<Convocados, DadosConvocadosViewModel>(_dadosConvocadosService.GetOne(predicate));
        }
    }
}