using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IPrimeiroAcessoAppService : IDisposable
    {
        Task<PrimeiroAcessoViewModel> AddAsync(PrimeiroAcessoViewModel obj);

        Task<PrimeiroAcessoViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<PrimeiroAcessoViewModel>> GetAllAsync();

        Task<PrimeiroAcessoViewModel> UpdateAsync(PrimeiroAcessoViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<PrimeiroAcessoViewModel>> SearchAsync(Expression<Func<PrimeiroAcesso, bool>> predicate);

        Task<PrimeiroAcessoViewModel> GetOneAsync(Expression<Func<PrimeiroAcesso, bool>> predicate);
    }
}