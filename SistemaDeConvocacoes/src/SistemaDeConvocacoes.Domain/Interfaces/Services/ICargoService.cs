﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface ICargoService : IDisposable
    {
        Cargo Add(Cargo obj);
        Cargo GetById(Guid id);
        IEnumerable<Cargo> GetAll();
        Cargo Update(Cargo obj);
        void Remove(Guid id);
        IEnumerable<Cargo> Search(Expression<Func<Cargo, bool>> predicate);
        Cargo GetOne(Expression<Func<Cargo, bool>> predicate);
    }
}