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

        public async Task<ConvocadoViewModel> AddAsync(ConvocadoViewModel obj)
        {
            var convocado = _mapper.Map<ConvocadoViewModel, Convocado>(obj);
            await _convocadoService.AddAsync(convocado);
            return obj;
        }

        public async Task<ConvocadoViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Convocado, ConvocadoViewModel>(await _convocadoService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<ConvocadoViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Convocado>, IEnumerable<ConvocadoViewModel>>(await _convocadoService.GetAllAsync());
        }

        public async Task<ConvocadoViewModel> UpdateAsync(ConvocadoViewModel obj)
        {
           await _convocadoService.UpdateAsync(_mapper.Map<ConvocadoViewModel, Convocado>(obj));
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
           await  _convocadoService.Remove(id);
        }

        public async Task<IEnumerable<ConvocadoViewModel>> SearchAsync(Expression<Func<Convocado, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Convocado>, IEnumerable<ConvocadoViewModel>>(
                await _convocadoService.SearchAsync(predicate));
        }

        public async Task<bool> VerificaSeHaSobrenome(string nome)
        {
            return await _convocadoService.VerificaSeHaSobrenome(nome);
        }

        public async Task<ConvocadoViewModel> GetOneAsync(Expression<Func<Convocado, bool>> predicate)
        {
            return _mapper.Map<Convocado, ConvocadoViewModel>(await _convocadoService.GetOneAsync(predicate));
        }
    }
}