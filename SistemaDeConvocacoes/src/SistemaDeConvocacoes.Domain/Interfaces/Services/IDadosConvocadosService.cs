﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IDadosConvocadosService : IDisposable
    {
        Convocado Add(Convocado obj);
        Convocado GetById(Guid id);
        IEnumerable<Convocado> GetAll();
        Convocado Update(Convocado obj);
        void Remove(Guid id);
        IEnumerable<Convocado> Search(Expression<Func<Convocado, bool>> predicate);
        Convocado GetOne(Expression<Func<Convocado, bool>> predicate);
        void SalvarCandidatos(Guid id, string file);
        void SalvarCargos(Guid id, string file);
    }
}