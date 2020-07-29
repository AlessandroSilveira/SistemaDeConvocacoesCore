using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
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

        public void Dispose()
        {
            _usuarioRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<Usuario> AddAsync(Usuario obj)
        {
            return await _usuarioRepository.AddAsync(obj);
        }

        public async Task<Usuario> GetByIdAsync(Guid id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Usuario>> GetAllAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task<Usuario> UpdateAsync(Usuario obj)
        {
            return await _usuarioRepository.UpdateAsync(obj);
        }

        public async Task RemoveAsync(Guid id)
        {
            await _usuarioRepository.RemoveAsync(id);
        }

        public async Task<IEnumerable<Usuario>> SearchAsync(Expression<Func<Usuario, bool>> predicate)
        {
            return await _usuarioRepository.SearchAsync(predicate);
        }

        public async Task<Usuario> GetOneAsync(Expression<Func<Usuario, bool>> predicate)
        {
            return await _usuarioRepository.GetOneAsync(predicate);
        }
    }
}