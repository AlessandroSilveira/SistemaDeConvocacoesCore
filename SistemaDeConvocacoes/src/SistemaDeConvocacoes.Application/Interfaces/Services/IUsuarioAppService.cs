using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IUsuarioAppService : IDisposable
    {
        Task<UsuarioViewModel> AddAsync(UsuarioViewModel obj);

        Task<UsuarioViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<UsuarioViewModel>> GetAllAsync();

        Task<UsuarioViewModel> UpdateAsync(UsuarioViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<UsuarioViewModel>> SearchAsync(Expression<Func<Usuario, bool>> predicate);

        Task<UsuarioViewModel> GetOneAsync(Expression<Func<Usuario, bool>> predicate);
    }
}