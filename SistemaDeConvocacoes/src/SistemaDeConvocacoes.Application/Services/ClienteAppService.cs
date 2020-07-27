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
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClientesService _clienteService;
        private readonly IMapper _mapper;

        public ClienteAppService(IClientesService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _clienteService.Dispose();
        }

        public ClienteViewModel Add(ClienteViewModel obj)
        {
            var cliente = _mapper.Map<ClienteViewModel, Clientes>(obj);
            _clienteService.Add(cliente);

            return obj;
        }

        public ClienteViewModel GetById(Guid id)
        {
            return _mapper.Map<Clientes, ClienteViewModel>(_clienteService.GetById(id));
        }

        public IEnumerable<ClienteViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Clientes>, IEnumerable<ClienteViewModel>>(_clienteService.GetAll());
        }

        public ClienteViewModel Update(ClienteViewModel obj)
        {
            _clienteService.Update(_mapper.Map<ClienteViewModel, Clientes>(obj));
            return obj;
        }

        public void Remove(Guid id)
        {
            _clienteService.Delete(id);
        }

        public IEnumerable<ClienteViewModel> Search(Expression<Func<Clientes, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Clientes>, IEnumerable<ClienteViewModel>>(_clienteService.Search(predicate));
        }

        public ClienteViewModel GetOne(Expression<Func<Clientes, bool>> predicate)
        {
            return _mapper.Map<Clientes, ClienteViewModel>(_clienteService.GetOne(predicate));
        }
    }
}