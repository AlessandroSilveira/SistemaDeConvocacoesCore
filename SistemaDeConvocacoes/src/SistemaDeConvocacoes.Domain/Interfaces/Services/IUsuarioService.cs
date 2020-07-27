using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SistemaDeConvocacoes.Domain.Entities;

namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IUsuarioService : IRepository<Usuario>
    {
        IQueryable<Usuario> GetAll();
        Task Add(Usuario entity);
        Task Update(Usuario entity);
        Task Delete(Guid id);
        IEnumerable<Usuario> Search(Expression<Func<Usuario, bool>> predicate);
        Usuario GetOne(Expression<Func<Usuario, bool>> predicate);
        int SaveChanges();
        void Dispose();
        Usuario GetById(Guid id);
    }
}