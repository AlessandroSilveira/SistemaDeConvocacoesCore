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
    public class ConvocadosService : IConvocadosService
    {
        public Task Create(Convocados entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

      
        public IQueryable<Convocados> GetAll()
        {
            throw new NotImplementedException();
        }

        public Convocados GetById(Guid guid)
        {
            throw new NotImplementedException();
        }

        public Convocados GetOne(Expression<Func<Convocados, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Convocados> Search(Expression<Func<Convocados, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Convocados entity)
        {
            throw new NotImplementedException();
        }
    }
}
