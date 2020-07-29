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
    public class ProcessoAppService : IProcessoAppService
    {
        private readonly IProcessoService _processoService;
        private readonly IMapper _mapper;

        public ProcessoAppService(IProcessoService processoService, IMapper mapper)
        {
            _processoService = processoService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _processoService.Dispose();
        }

        public async Task<ProcessoViewModel> AddAsync(ProcessoViewModel obj)
        {
            var admin = _mapper.Map<ProcessoViewModel, Processo>(obj);           
            await _processoService.AddAsync(admin);            
            return obj;
        }

        public async Task<ProcessoViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Processo, ProcessoViewModel>(await _processoService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<ProcessoViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Processo>, IEnumerable<ProcessoViewModel>>(await _processoService.GetAllAsync());
        }

        public async Task<ProcessoViewModel> UpdateAsync(ProcessoViewModel obj)
        {
            await _processoService.UpdateAsync(_mapper.Map<ProcessoViewModel, Processo>(obj));            
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {           
            await _processoService.RemoveAsync(id);            
        }

        public async Task<IEnumerable<ProcessoViewModel>> SearchAsync(Expression<Func<Processo, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Processo>, IEnumerable<ProcessoViewModel>>(
                await _processoService.SearchAsync(predicate));
        }

        public async Task<ProcessoViewModel> GetOneAsync(Expression<Func<Processo, bool>> predicate)
        {
            return _mapper.Map<Processo, ProcessoViewModel>(await _processoService.GetOneAsync(predicate));
        }
    }
}