using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IAdminAppService : IDisposable
    {
        Task<Admin2ViewModel> AddAsync(Admin2ViewModel obj);

        Task<Admin2ViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<Admin2ViewModel>> GetAllAsync();

        Task<Admin2ViewModel> UpdateAsync(Admin2ViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<Admin2ViewModel>> SearchAsync(Expression<Func<Admin, bool>> predicate);

        Task<Admin2ViewModel> GetOneAsync(Expression<Func<Admin, bool>> predicate);
    }
}