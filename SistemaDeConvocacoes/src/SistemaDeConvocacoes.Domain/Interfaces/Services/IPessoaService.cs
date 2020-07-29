using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IPessoaService : IDisposable
    {
        Task<Pessoa> AddAsync(Pessoa obj);
        Task<Pessoa> GetByIdAsync(Guid id);
        Task<IEnumerable<Pessoa>> GetAllAsync();
        Task<Pessoa> UpdateAsync(Pessoa obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Pessoa>> SearchAsync(Expression<Func<Pessoa, bool>> predicate);
        Task<Pessoa> GetOneAsync(Expression<Func<Pessoa, bool>> predicate);
    }
}