using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IConvocadoAppService : IDisposable
    {
        Task<ConvocadoViewModel> AddAsync(ConvocadoViewModel obj);

        Task<ConvocadoViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<ConvocadoViewModel>> GetAllAsync();

        Task<ConvocadoViewModel> UpdateAsync(ConvocadoViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<ConvocadoViewModel>> SearchAsync(Expression<Func<Convocado, bool>> predicate);

        Task<bool> VerificaSeHaSobrenome(string nome);

        Task<ConvocadoViewModel> GetOneAsync(Expression<Func<Convocado, bool>> predicate);
    }
}