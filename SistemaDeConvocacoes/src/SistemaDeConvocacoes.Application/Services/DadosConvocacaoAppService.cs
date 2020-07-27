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
    public class DadosConvocacaoAppService : IDadosConvocacaoAppService
    {
        private readonly IDadosConvocadosService _dadosConvocadosService;
        private readonly IMapper _mapper;

        public DadosConvocacaoAppService(IDadosConvocadosService dadosConvocadosService, IMapper mapper)
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
            var convocado = _mapper.Map<DadosConvocadosViewModel, Convocado>(obj);
            _dadosConvocadosService.Add(convocado);
            return obj;
        }

        public DadosConvocadosViewModel GetById(Guid id)
        {
            return _mapper.Map<Convocado, DadosConvocadosViewModel>(_dadosConvocadosService.GetById(id));
        }

        public IEnumerable<DadosConvocadosViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Convocado>, IEnumerable<DadosConvocadosViewModel>>(_dadosConvocadosService
                .GetAll());
        }

        public DadosConvocadosViewModel Update(DadosConvocadosViewModel obj)
        {
            _dadosConvocadosService.Update(_mapper.Map<DadosConvocadosViewModel, Convocado>(obj));
            return obj;
        }

        public void Remove(Guid id)
        {
            _dadosConvocadosService.Remove(id);
        }

        public IEnumerable<DadosConvocadosViewModel> Search(Expression<Func<Convocado, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Convocado>, IEnumerable<DadosConvocadosViewModel>>(
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

        public DadosConvocadosViewModel GetOne(Expression<Func<Convocado, bool>> predicate)
        {
            return _mapper.Map<Convocado, DadosConvocadosViewModel>(_dadosConvocadosService.GetOne(predicate));
        }
    }
}