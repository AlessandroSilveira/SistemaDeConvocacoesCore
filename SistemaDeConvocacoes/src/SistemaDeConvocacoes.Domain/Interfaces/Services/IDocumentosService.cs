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
        IQueryable<Documentos> GetAll();
        Task Create(Documentos entity);
        Task Update(int id, Documentos entity);
        Task Delete(int id);
        IEnumerable<Documentos> Search(Expression<Func<Documentos, bool>> predicate);
        Documentos GetOne(Expression<Func<Documentos, bool>> predicate);
        int SaveChanges();
        
    }
}