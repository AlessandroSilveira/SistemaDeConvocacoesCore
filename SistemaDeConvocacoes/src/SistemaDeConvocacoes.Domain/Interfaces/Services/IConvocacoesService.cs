using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IConvocacoesService 
    {
        IQueryable<Convocacoes> GetAll();
        Task Add(Convocacoes entity);
        Task Update(Convocacoes entity);
        Task Delete(Guid id);
        IEnumerable<Convocacoes> Search(Expression<Func<Convocacoes, bool>> predicate);
        Convocacoes GetOne(Expression<Func<Convocacoes, bool>> predicate);
        int SaveChanges();
        void Dispose();
        string GeneratePassword();
        Convocacoes GetById(Guid id);
    }
}