using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IConvocacaoService : IDisposable
    {
        Task<Convocacao> AddAsync(Convocacao obj);
        Task<Convocacao> GetByIdAsync(Guid id);
        Task<IEnumerable<Convocacao>> GetAllAsync();
        Task<Convocacao> UpdateAsync(Convocacao obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Convocacao>> SearchAsync(Expression<Func<Convocacao, bool>> predicate);
        Task<Convocacao> GetOneAsync(Expression<Func<Convocacao, bool>> predicate);
        Task<string> GeneratePasswordAsync();
        IEnumerable<Convocacao> MontarListaDeConvocados(IEnumerable<Convocacao> dadosConfirmados, IEnumerable<Convocacao> convocados);
        Task DetachLocal(Func<Convocacao, bool> func);
    }
}