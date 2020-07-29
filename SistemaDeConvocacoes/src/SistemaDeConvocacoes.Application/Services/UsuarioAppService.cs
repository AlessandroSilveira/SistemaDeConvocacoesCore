using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Application.Services
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioAppService(IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _usuarioService.Dispose();
        }

        public async Task<UsuarioViewModel> AddAsync(UsuarioViewModel obj)
        {
            var telefone = _mapper.Map<UsuarioViewModel, Usuario>(obj);
            await _usuarioService.AddAsync(telefone);
            return obj;
        }

        public async Task<UsuarioViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Usuario, UsuarioViewModel>(await _usuarioService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<UsuarioViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(await _usuarioService.GetAllAsync());
        }

        public async Task<UsuarioViewModel> UpdateAsync(UsuarioViewModel obj)
        {
            await _usuarioService.UpdateAsync(_mapper.Map<UsuarioViewModel, Usuario>(obj));

            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
            await _usuarioService.RemoveAsync(id);
        }

        public async Task<IEnumerable<UsuarioViewModel>> SearchAsync(Expression<Func<Usuario, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(await _usuarioService.SearchAsync(predicate));
        }

        public async Task<UsuarioViewModel> GetOneAsync(Expression<Func<Usuario, bool>> predicate)
        {
            return _mapper.Map<Usuario, UsuarioViewModel>(await _usuarioService.GetOneAsync(predicate));
        }
    }
}