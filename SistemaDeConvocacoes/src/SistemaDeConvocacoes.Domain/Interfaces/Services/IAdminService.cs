using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IAdminService :IDisposable
    {
        IQueryable<Admin> GetAll();
        Task Add(Admin entity);
        Task Update(Admin entity);
        Task Delete(Guid id);
        IEnumerable<Admin> Search(Expression<Func<Admin, bool>> predicate);
        int SaveChanges();
        void Dispose();
        Admin GetOne(Expression<Func<Admin, bool>> predicate);
        Admin GetById(Guid id);
    }
}