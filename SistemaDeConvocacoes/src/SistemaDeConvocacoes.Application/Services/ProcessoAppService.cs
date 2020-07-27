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

        public ProcessoViewModel Add(ProcessoViewModel obj)
        {
            var admin = _mapper.Map<ProcessoViewModel, Processo>(obj);           
            _processoService.Add(admin);            
            return obj;
        }

        public ProcessoViewModel GetById(Guid id)
        {
            return _mapper.Map<Processo, ProcessoViewModel>(_processoService.GetById(id));
        }

        public IEnumerable<ProcessoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Processo>, IEnumerable<ProcessoViewModel>>(_processoService.GetAll());
        }

        public ProcessoViewModel Update(ProcessoViewModel obj)
        {           
            _processoService.Update(_mapper.Map<ProcessoViewModel, Processo>(obj));            
            return obj;
        }

        public void Remove(Guid id)
        {           
            _processoService.Remove(id);            
        }

        public IEnumerable<ProcessoViewModel> Search(Expression<Func<Processo, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Processo>, IEnumerable<ProcessoViewModel>>(
                _processoService.Search(predicate));
        }

        public ProcessoViewModel GetOne(Expression<Func<Processo, bool>> predicate)
        {
            return _mapper.Map<Processo, ProcessoViewModel>(_processoService.GetOne(predicate));
        }
    }
}