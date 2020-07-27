using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IProcessoService : IDisposable
    {
        Processo Add(Processo obj);
        Processo GetById(Guid id);
        IEnumerable<Processo> GetAll();
        Processo Update(Processo obj);
        void Remove(Guid id);
        IEnumerable<Processo> Search(Expression<Func<Processo, bool>> predicate);
        Processo GetOne(Expression<Func<Processo, bool>> predicate);
    }
}