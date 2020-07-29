using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IPessoaAppService : IDisposable
    {
        Task<PessoaViewModel> AddAsync(PessoaViewModel obj);

        Task<PessoaViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<PessoaViewModel>> GetAllAsync();

        Task<PessoaViewModel> UpdateAsync(PessoaViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<PessoaViewModel>> SearchAsync(Expression<Func<Pessoa, bool>> predicate);

        Task<PessoaViewModel> GetOneAsync(Expression<Func<Pessoa, bool>> predicate);
    }
}