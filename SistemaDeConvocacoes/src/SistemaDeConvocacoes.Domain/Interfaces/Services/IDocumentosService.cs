using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDocumentosService 
    {
        IQueryable<Documento> GetAll();
        Task Create(Documento entity);
        Task Update(int id, Documento entity);
        Task Delete(int id);
        IEnumerable<Documento> Search(Expression<Func<Documento, bool>> predicate);
        Documento GetOne(Expression<Func<Documento, bool>> predicate);
        int SaveChanges();
        
    }
}