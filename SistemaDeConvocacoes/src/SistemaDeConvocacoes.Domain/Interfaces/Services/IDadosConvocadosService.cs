using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDadosConvocadosService : IDisposable
    {
        Task<Convocado> AddAsync(Convocado obj);
        Task<Convocado> GetByIdAsync(Guid id);
        Task<IEnumerable<Convocado>> GetAllAsync();
        Task<Convocado> UpdateAsync(Convocado obj);
        Task RemoveAsync(Guid id);
        Task<IEnumerable<Convocado>> SearchAsync(Expression<Func<Convocado, bool>> predicate);
        Task<Convocado> GetOneAsync(Expression<Func<Convocado, bool>> predicate);
        Task SalvarCandidatosAsync(Guid id, string file);
        Task SalvarCargosAsync(Guid id, string file);
    }
}