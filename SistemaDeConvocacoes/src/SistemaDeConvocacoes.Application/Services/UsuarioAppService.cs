using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public UsuarioViewModel Add(UsuarioViewModel obj)
        {
            var telefone = _mapper.Map<UsuarioViewModel, Usuario>(obj);
            _usuarioService.Add(telefone);
            return obj;
        }

        public UsuarioViewModel GetById(Guid id)
        {
            return _mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.GetById(id));
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.GetAll());
        }

        public UsuarioViewModel Update(UsuarioViewModel obj)
        {
            _usuarioService.Update(_mapper.Map<UsuarioViewModel, Usuario>(obj));

            return obj;
        }

        public void Remove(Guid id)
        {
            _usuarioService.Remove(id);
        }

        public IEnumerable<UsuarioViewModel> Search(Expression<Func<Usuario, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.Search(predicate));
        }

        public UsuarioViewModel GetOne(Expression<Func<Usuario, bool>> predicate)
        {
            return _mapper.Map<Usuario, UsuarioViewModel>(_usuarioService.GetOne(predicate));
        }
    }
}