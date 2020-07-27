using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class ProcessosService : IProcessosService
    {
        public Task Create(Processos entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

      

        public IQueryable<Processos> GetAll()
        {
            throw new NotImplementedException();
        }

        public Processos GetById(object processoId)
        {
            throw new NotImplementedException();
        }

        public Processos GetOne(Expression<Func<Processos, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Processos> Search(Expression<Func<Processos, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Processos entity)
        {
            throw new NotImplementedException();
        }
    }
}
