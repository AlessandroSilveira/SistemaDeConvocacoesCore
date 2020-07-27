using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IProcessoAppService : IDisposable
    {
        ProcessoViewModel Add(ProcessoViewModel obj);

        ProcessoViewModel GetById(Guid id);

        IEnumerable<ProcessoViewModel> GetAll();

        ProcessoViewModel Update(ProcessoViewModel obj);

        void Remove(Guid id);

        IEnumerable<ProcessoViewModel> Search(Expression<Func<Processo, bool>> predicate);

        ProcessoViewModel GetOne(Expression<Func<Processo, bool>> predicate);
    }
}