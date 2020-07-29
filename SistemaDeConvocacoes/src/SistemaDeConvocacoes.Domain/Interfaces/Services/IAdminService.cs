using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IAdminService : IDisposable
    {
        Task<Admin> AddAsync(Admin obj);
        Task<Admin> GetByIdAsync(Guid id);
        Task<IEnumerable<Admin>> GetAllAsync();
        Task<Admin> UpdateAsync(Admin obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Admin>> SearchAsync(Expression<Func<Admin, bool>> predicate);
        Task<Admin> GetOneAsync(Expression<Func<Admin, bool>> predicate);
    }
}