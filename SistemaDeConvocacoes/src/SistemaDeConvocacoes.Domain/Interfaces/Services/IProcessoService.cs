using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IProcessosService 
    {
        IQueryable<Processos> GetAll();
        Task Add(Processos entity);
        Task Update(Processos entity);
        Task Delete(Guid id);
        IEnumerable<Processos> Search(Expression<Func<Processos, bool>> predicate);
        Processos GetOne(Expression<Func<Processos, bool>> predicate);
        int SaveChanges();        
        Processos GetById(object processoId);
        void Dispose();
    }
}