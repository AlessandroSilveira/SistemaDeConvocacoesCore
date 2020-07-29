using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IUsuarioService : IDisposable
    {
        Task<Usuario> AddAsync(Usuario obj);
        Task<Usuario> GetByIdAsync(Guid id);
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task<Usuario> UpdateAsync(Usuario obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Usuario>> SearchAsync(Expression<Func<Usuario, bool>> predicate);
        Task<Usuario> GetOneAsync(Expression<Func<Usuario, bool>> predicate);
    }
}