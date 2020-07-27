using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IPessoaAppService : IDisposable
    {
        PessoaViewModel Add(PessoaViewModel obj);

        PessoaViewModel GetById(Guid id);

        IEnumerable<PessoaViewModel> GetAll();

        PessoaViewModel Update(PessoaViewModel obj);

        void Remove(Guid id);

        IEnumerable<PessoaViewModel> Search(Expression<Func<Pessoa, bool>> predicate);

        PessoaViewModel GetOne(Expression<Func<Pessoa, bool>> predicate);
    }
}