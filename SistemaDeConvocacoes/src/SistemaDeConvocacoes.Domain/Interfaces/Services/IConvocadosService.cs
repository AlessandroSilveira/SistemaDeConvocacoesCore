using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IConvocadosService
    {
        IQueryable<Convocados> GetAll();
        Task Add(Convocados entity);
        Task Update(Convocados entity);
        Task Delete(Guid id);
        IEnumerable<Convocados> Search(Expression<Func<Convocados, bool>> predicate);
        Convocados GetOne(Expression<Func<Convocados, bool>> predicate);
        int SaveChanges();
        
        Convocados GetById(Guid guid);
        void Dispose();
        bool VerificaSeHaSobrenome(string nome);
    }
}