using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class ConvocacoesService : IConvocacoesService
    {
        public Task Create(Convocacoes entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

       

        public IQueryable<Convocacoes> GetAll()
        {
            throw new NotImplementedException();
        }

        public Convocacoes GetOne(Expression<Func<Convocacoes, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Convocacoes> Search(Expression<Func<Convocacoes, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Convocacoes entity)
        {
            throw new NotImplementedException();
        }
    }
}
