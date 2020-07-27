using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IClientesService : IDisposable
    {
        IQueryable<Clientes> GetAll();
        Task Add(Clientes entity);
        Task Update(Clientes entity);
        Task Delete(Guid id);
        IEnumerable<Clientes> Search(Expression<Func<Clientes, bool>> predicate);
        Clientes GetOne(Expression<Func<Clientes, bool>> predicate);
        int SaveChanges();
        void Dispose();
        Clientes GetById(Guid id);
    }
}