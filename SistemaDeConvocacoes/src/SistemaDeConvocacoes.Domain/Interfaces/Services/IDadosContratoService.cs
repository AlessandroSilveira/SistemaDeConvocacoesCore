using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDadosContatoService : IDisposable
    {
        IQueryable<DadosContato> GetAll();
        Task Create(DadosContato entity);
        Task Update(int id, DadosContato entity);
        Task Delete(int id);
        IEnumerable<DadosContato> Search(Expression<Func<DadosContato, bool>> predicate);
        DadosContato GetOne(Expression<Func<DadosContato, bool>> predicate);
        int SaveChanges();
        void Dispose();
    }
}