using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDadosConvocadosService : IDisposable
    {
        Convocados Add(Convocados obj);
        Convocados GetById(Guid id);
        IEnumerable<Convocados> GetAll();
        Convocados Update(Convocados obj);
        void Remove(Guid id);
        IEnumerable<Convocados> Search(Expression<Func<Convocados, bool>> predicate);
        Convocados GetOne(Expression<Func<Convocados, bool>> predicate);
        void SalvarCandidatos(Guid id, string file);
        void SalvarCargos(Guid id, string file);
    }
}