using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void DisposeAsync()
        {
            _usuarioRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Usuario Add(Usuario obj)
        {
            return _usuarioRepository.Add(obj);
        }

        public Usuario GetById(Guid id)
        {
            return _usuarioRepository.GetById(id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        public Usuario Update(Usuario obj)
        {
            return _usuarioRepository.Update(obj);
        }

        public void Remove(Guid id)
        {
            _usuarioRepository.Remove(id);
        }

        public IEnumerable<Usuario> Search(Expression<Func<Usuario, bool>> predicate)
        {
            return _usuarioRepository.Search(predicate);
        }

        public Usuario GetOne(Expression<Func<Usuario, bool>> predicate)
        {
            return _usuarioRepository.GetOne(predicate);
        }
    }
}