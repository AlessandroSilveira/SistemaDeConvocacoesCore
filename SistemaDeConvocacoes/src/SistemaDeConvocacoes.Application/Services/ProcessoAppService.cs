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
        private readonly IProcessosService _processoService;
        private readonly IMapper _mapper;

        public ProcessoAppService(IProcessosService processoService, IMapper mapper)
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
            var admin = _mapper.Map<ProcessoViewModel, Processos>(obj);           
            _processoService.Add(admin);            
            return obj;
        }

        public ProcessoViewModel GetById(Guid id)
        {
            return _mapper.Map<Processos, ProcessoViewModel>(_processoService.GetById(id));
        }

        public IEnumerable<ProcessoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Processos>, IEnumerable<ProcessoViewModel>>(_processoService.GetAll());
        }

        public ProcessoViewModel Update(ProcessoViewModel obj)
        {           
            _processoService.Update(_mapper.Map<ProcessoViewModel, Processos>(obj));            
            return obj;
        }

        public void Remove(Guid id)
        {           
            _processoService.Delete(id);            
        }

        public IEnumerable<ProcessoViewModel> Search(Expression<Func<Processos, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Processos>, IEnumerable<ProcessoViewModel>>(
                _processoService.Search(predicate));
        }

        public ProcessoViewModel GetOne(Expression<Func<Processos, bool>> predicate)
        {
            return _mapper.Map<Processos, ProcessoViewModel>(_processoService.GetOne(predicate));
        }
    }
}