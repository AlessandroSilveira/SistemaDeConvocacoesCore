using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IAdminService : IDisposable
    {
        Admin Add(Admin obj);
        Admin GetById(Guid id);
        IEnumerable<Admin> GetAll();
        Admin Update(Admin obj);
        void Remove(Guid id);
        IEnumerable<Admin> Search(Expression<Func<Admin, bool>> predicate);
        Admin GetOne(Expression<Func<Admin, bool>> predicate);
    }
}