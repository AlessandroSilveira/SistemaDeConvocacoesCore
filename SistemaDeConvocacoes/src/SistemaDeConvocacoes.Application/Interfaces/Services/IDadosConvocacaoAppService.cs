using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IDadosConvocacaoAppService : IDisposable
    {
        DadosConvocadosViewModel Add(DadosConvocadosViewModel obj);

        DadosConvocadosViewModel GetById(Guid id);

        IEnumerable<DadosConvocadosViewModel> GetAll();

        DadosConvocadosViewModel Update(DadosConvocadosViewModel obj);

        void Remove(Guid id);

        IEnumerable<DadosConvocadosViewModel> Search(Expression<Func<Convocado, bool>> predicate);

        void SalvarCandidatos(Guid id, string file);

        void SalvarCargos(Guid id, string format);

        DadosConvocadosViewModel GetOne(Expression<Func<Convocado, bool>> predicate);
    }
}