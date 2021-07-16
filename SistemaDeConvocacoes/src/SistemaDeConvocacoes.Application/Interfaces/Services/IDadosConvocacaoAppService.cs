using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IDadosConvocacaoAppService : IDisposable
    {
        Task<DadosConvocadosViewModel> AddAsync(DadosConvocadosViewModel obj);

        Task<DadosConvocadosViewModel> GetByIdAsync(Guid id);

        Task<IEnumerable<DadosConvocadosViewModel>> GetAllAsync();

        Task<DadosConvocadosViewModel> UpdateAsync(DadosConvocadosViewModel obj);

        Task RemoveAsync(Guid id);

        Task<IEnumerable<DadosConvocadosViewModel>> SearchAsync(Expression<Func<Convocado, bool>> predicate);

       
        Task<DadosConvocadosViewModel> GetOneAsync(Expression<Func<Convocado, bool>> predicate);
        Task SalvarCargosAsync(Guid id, List<Cargo> listaCargo);
        Task SalvarCandidatosAsync(Guid id, List<Convocado> listaConvocados );
    }
}