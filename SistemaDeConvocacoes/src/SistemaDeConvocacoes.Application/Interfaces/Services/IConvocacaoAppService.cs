using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IConvocacaoAppService : IDisposable
    {
        Task<ConvocacaoViewModel> AddAsync(ConvocacaoViewModel obj);

        Task<ConvocacaoViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<ConvocacaoViewModel>> GetAllAsync();

        Task<ConvocacaoViewModel> UpdateAsync(ConvocacaoViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<ConvocacaoViewModel>> SearchAsync(Expression<Func<Convocacao, bool>> predicate);

        Task<string> GerarSenhaUsuarioAsync();

        List<ConvocadoViewModel> MontaListaDeConvocados(IEnumerable<ConvocacaoViewModel> dadosConfirmados,
            IEnumerable<ConvocadoViewModel> convocados);

        Task<ConvocacaoViewModel> GetOneAsync(Expression<Func<Convocacao, bool>> predicate);
        void DetachLocal(Func<Convocacao, bool> func);
    }
}