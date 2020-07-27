using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface ICargoAppService : IDisposable
    {
        CargoViewModel Add(CargoViewModel obj);

        CargoViewModel GetById(Guid id);

        IEnumerable<CargoViewModel> GetAll();

        CargoViewModel Update(CargoViewModel obj);

        void Remove(Guid id);

        IEnumerable<CargoViewModel> Search(Expression<Func<Cargos, bool>> predicate);

        CargoViewModel GetOne(Expression<Func<Cargos, bool>> predicate);
    }
}