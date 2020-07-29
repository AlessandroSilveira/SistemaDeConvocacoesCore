using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface ICargoAppService : IDisposable
    {
        Task<CargoViewModel> AddAsync(CargoViewModel obj);

        Task<CargoViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<CargoViewModel>> GetAllAsync();

        Task<CargoViewModel> UpdateAsync(CargoViewModel obj);

        Task Remove(Guid id);

        Task<IEnumerable<CargoViewModel>> SearchAsync(Expression<Func<Cargo, bool>> predicate);

        Task<CargoViewModel> GetOneAsync(Expression<Func<Cargo, bool>> predicate);
    }
}