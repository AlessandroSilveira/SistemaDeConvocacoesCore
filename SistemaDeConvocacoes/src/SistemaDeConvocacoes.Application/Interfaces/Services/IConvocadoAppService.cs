using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IConvocadoAppService : IDisposable
    {
        ConvocadoViewModel Add(ConvocadoViewModel obj);

        ConvocadoViewModel GetById(Guid id);

        IEnumerable<ConvocadoViewModel> GetAll();

        ConvocadoViewModel Update(ConvocadoViewModel obj);

        void Remove(Guid id);

        IEnumerable<ConvocadoViewModel> Search(Expression<Func<Convocado, bool>> predicate);

        bool VerificaSeHaSobrenome(string nome);

        ConvocadoViewModel GetOne(Expression<Func<Convocado, bool>> predicate);
    }
}