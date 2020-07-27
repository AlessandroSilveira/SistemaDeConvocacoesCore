using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDocumentoCandidatoService : IDisposable
    {
        IQueryable<DocumentoCandidato> GetAll();
        Task Add(DocumentoCandidato entity);
        Task Update(DocumentoCandidato entity);
        Task Delete(Guid id);
        IEnumerable<DocumentoCandidato> Search(Expression<Func<DocumentoCandidato, bool>> predicate);
        DocumentoCandidato GetOne(Expression<Func<DocumentoCandidato, bool>> predicate);
        int SaveChanges();
        void Dispose();
        DocumentoCandidato GetById(Guid id);
    }
}