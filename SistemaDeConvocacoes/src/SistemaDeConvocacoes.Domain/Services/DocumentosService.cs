using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class DocumentosService : IDocumentosService
    {
        public Task Create(Documentos entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

   
        public IQueryable<Documentos> GetAll()
        {
            throw new NotImplementedException();
        }

        public Documentos GetOne(Expression<Func<Documentos, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Documentos> Search(Expression<Func<Documentos, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Documentos entity)
        {
            throw new NotImplementedException();
        }
    }
}
