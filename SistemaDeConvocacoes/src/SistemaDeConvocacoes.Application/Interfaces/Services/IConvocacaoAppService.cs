using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IConvocacaoAppService : IDisposable
    {
        ConvocacaoViewModel Add(ConvocacaoViewModel obj);

        ConvocacaoViewModel GetById(Guid id);

        IEnumerable<ConvocacaoViewModel> GetAll();

        ConvocacaoViewModel Update(ConvocacaoViewModel obj);

        void Remove(Guid id);

        IEnumerable<ConvocacaoViewModel> Search(Expression<Func<Convocacao, bool>> predicate);

        string GerarSenhaUsuario();

        List<ConvocadoViewModel> MontaListaDeConvocados(IEnumerable<ConvocacaoViewModel> dadosConfirmados,
            IEnumerable<ConvocadoViewModel> convocados);

        ConvocacaoViewModel GetOne(Expression<Func<Convocacao, bool>> predicate);
    }
}