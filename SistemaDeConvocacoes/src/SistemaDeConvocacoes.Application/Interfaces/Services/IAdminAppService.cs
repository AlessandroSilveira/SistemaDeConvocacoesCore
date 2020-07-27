using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IAdminAppService : IDisposable
    {
        Admin2ViewModel Add(Admin2ViewModel obj);

        Admin2ViewModel GetById(Guid id);

        IEnumerable<Admin2ViewModel> GetAll();

        Admin2ViewModel Update(Admin2ViewModel obj);

        void Remove(Guid id);

        IEnumerable<Admin2ViewModel> Search(Expression<Func<Admin, bool>> predicate);

        Admin2ViewModel GetOne(Expression<Func<Admin, bool>> predicate);
    }
}