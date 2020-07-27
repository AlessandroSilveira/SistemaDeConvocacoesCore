using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IUsuarioAppService : IDisposable
    {
        UsuarioViewModel Add(UsuarioViewModel obj);

        UsuarioViewModel GetById(Guid id);

        IEnumerable<UsuarioViewModel> GetAll();

        UsuarioViewModel Update(UsuarioViewModel obj);

        void Remove(Guid id);

        IEnumerable<UsuarioViewModel> Search(Expression<Func<Usuario, bool>> predicate);

        UsuarioViewModel GetOne(Expression<Func<Usuario, bool>> predicate);
    }
}