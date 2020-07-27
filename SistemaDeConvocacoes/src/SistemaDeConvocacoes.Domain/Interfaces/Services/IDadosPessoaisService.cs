using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDadosPessoaisService : IDisposable
    {
        IQueryable<DadosPessoais> GetAll();
        Task Create(DadosPessoais entity);
        Task Update(int id, DadosPessoais entity);
        Task Delete(int id);
        IEnumerable<DadosPessoais> Search(Expression<Func<DadosPessoais, bool>> predicate);
        DadosPessoais GetOne(Expression<Func<DadosPessoais, bool>> predicate);
        int SaveChanges();
        void Dispose();
    }
}