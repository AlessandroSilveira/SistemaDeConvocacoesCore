using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ITelefonesService : IRepository<Telefones>
    {
        IQueryable<Telefones> GetAll();
        Task Create(Telefones entity);
        Task Update(int id, Telefones entity);
        Task Delete(int id);
        IEnumerable<Telefones> Search(Expression<Func<Telefones, bool>> predicate);
        Telefones GetOne(Expression<Func<Telefones, bool>> predicate);
        int SaveChanges();
        void Dispose();
    }
}