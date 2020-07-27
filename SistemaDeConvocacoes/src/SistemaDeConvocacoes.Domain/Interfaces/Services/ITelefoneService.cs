using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ITelefoneService : IDisposable
    {
        Telefone Add(Telefone obj);
        Telefone GetById(Guid id);
        IEnumerable<Telefone> GetAll();
        Telefone Update(Telefone obj);
        void Remove(Guid id);
        IEnumerable<Telefone> Search(Expression<Func<Telefone, bool>> predicate);
        Telefone GetOne(Expression<Func<Telefone, bool>> predicate);
    }
}