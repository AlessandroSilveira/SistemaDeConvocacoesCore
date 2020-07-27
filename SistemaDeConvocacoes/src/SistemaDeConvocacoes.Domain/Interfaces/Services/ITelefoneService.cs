using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ITelefoneService : IRepository<Telefone>
    {
        IQueryable<Telefone> GetAll();
        Task Add(Telefone entity);
        Task Update(Telefone entity);
        Task Delete(Guid id);
        IEnumerable<Telefone> Search(Expression<Func<Telefone, bool>> predicate);
        Telefone GetOne(Expression<Func<Telefone, bool>> predicate);
        int SaveChanges();
        void Dispose();
        Telefone GetById(Guid id);
    }
}