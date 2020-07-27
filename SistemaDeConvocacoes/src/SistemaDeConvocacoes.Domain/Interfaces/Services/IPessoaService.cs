using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IPessoaService : IDisposable
    {
        IQueryable<Pessoa> GetAll();
        Task Add(Pessoa entity);
        Task Update(Pessoa entity);
        Task Delete(Guid id);
        IEnumerable<Pessoa> Search(Expression<Func<Pessoa, bool>> predicate);
        Pessoa GetOne(Expression<Func<Pessoa, bool>> predicate);
        int SaveChanges();
        void Dispose();
        Pessoa GetById(Guid id);
    }
}