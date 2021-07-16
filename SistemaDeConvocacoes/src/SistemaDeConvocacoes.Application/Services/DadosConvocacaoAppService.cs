using AutoMapper;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

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

        public async Task<DadosConvocadosViewModel> AddAsync(DadosConvocadosViewModel obj)
        {
            var convocado = _mapper.Map<DadosConvocadosViewModel, Convocado>(obj);
            await _dadosConvocadosService.AddAsync(convocado);
            return obj;
        }

        public async Task<DadosConvocadosViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Convocado, DadosConvocadosViewModel>(await _dadosConvocadosService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<DadosConvocadosViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Convocado>, IEnumerable<DadosConvocadosViewModel>>(await _dadosConvocadosService
                .GetAllAsync());
        }

        public async Task<DadosConvocadosViewModel> UpdateAsync(DadosConvocadosViewModel obj)
        {
            await _dadosConvocadosService.UpdateAsync(_mapper.Map<DadosConvocadosViewModel, Convocado>(obj));
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
            await _dadosConvocadosService.RemoveAsync(id);
        }

        public async Task<IEnumerable<DadosConvocadosViewModel>> SearchAsync(Expression<Func<Convocado, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Convocado>, IEnumerable<DadosConvocadosViewModel>>(
               await _dadosConvocadosService.SearchAsync(predicate));
        }

       

        public async Task<DadosConvocadosViewModel> GetOneAsync(Expression<Func<Convocado, bool>> predicate)
        {
            return _mapper.Map<Convocado, DadosConvocadosViewModel>(await _dadosConvocadosService.GetOneAsync(predicate));
        }

        public async Task SalvarCargosAsync(Guid id, List<Cargo> listaCargo )
        {
            await _dadosConvocadosService.SalvarCargosAsync(id, listaCargo);
        }

        public async Task SalvarCandidatosAsync(Guid id, List<Convocado> listaConvocados)
        {
            await _dadosConvocadosService.SalvarCandidatosAsync(id, listaConvocados);
        }
    }
}