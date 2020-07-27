using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ICargosService : IDisposable
    {
        IQueryable<Cargos> GetAll();
        Task Add(Cargos entity);
        Task Update(Cargos entity);
        Task Delete(Guid id);
        IEnumerable<Cargos> Search(Expression<Func<Cargos, bool>> predicate);
        Cargos GetOne(Expression<Func<Cargos, bool>> predicate);
        int SaveChanges();
        void Dispose();
        Cargos GetById(Guid id);
    }
}