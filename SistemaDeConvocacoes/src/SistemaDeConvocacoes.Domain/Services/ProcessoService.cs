using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class ProcessoService : IProcessoService
    {
        private readonly IProcessoRepository _processoRepository;

        public ProcessoService(IProcessoRepository processoRepository)
        {
            _processoRepository = processoRepository;
        }

        public void DisposeAsync()
        {
            _processoRepository.Dispose();
        }

        public Processo Add(Processo obj)
        {
            return _processoRepository.Add(obj);
        }

        public Processo GetById(Guid id)
        {
            return _processoRepository.GetById(id);
        }

        public IEnumerable<Processo> GetAll()
        {
            return _processoRepository.GetAll();
        }

        public Processo Update(Processo obj)
        {
            return _processoRepository.Update(obj);
        }

        public void Remove(Guid id)
        {
            _processoRepository.Remove(id);
        }

        public IEnumerable<Processo> Search(Expression<Func<Processo, bool>> predicate)
        {
            return _processoRepository.Search(predicate);
        }

        public Processo GetOne(Expression<Func<Processo, bool>> predicate)
        {
            return _processoRepository.GetOne(predicate);
        }
    }
}