using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IConvocacaoService : IDisposable
    {
        Convocacao Add(Convocacao obj);
        Convocacao GetById(Guid id);
        IEnumerable<Convocacao> GetAll();
        Convocacao Update(Convocacao obj);
        void Remove(Guid id);
        IEnumerable<Convocacao> Search(Expression<Func<Convocacao, bool>> predicate);
        Convocacao GetOne(Expression<Func<Convocacao, bool>> predicate);
        string GeneratePassword();
        IEnumerable<Convocacao> MontarListaDeConvocados(IEnumerable<Convocacao> dadosConfirmados, IEnumerable<Convocacao> convocados);
    }
}