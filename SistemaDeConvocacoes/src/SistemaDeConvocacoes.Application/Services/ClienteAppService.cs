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
    public class ClienteAppService : IClienteAppService
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClienteAppService(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        public void Dispose()
        {
           _clienteService.Dispose();
        }

        public async Task<ClienteViewModel> Add(ClienteViewModel obj)
        {
            var cliente = _mapper.Map<ClienteViewModel, Cliente>(obj);
            await _clienteService.Add(cliente);

            return obj;
        }

        public async Task<ClienteViewModel> GetById(Guid id)
        {
            return _mapper.Map<Cliente, ClienteViewModel>(await _clienteService.GetById(id));
        }

        public async Task<IEnumerable<ClienteViewModel>> GetAll()
        {
            return _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(await _clienteService.GetAll());
        }

        public async Task<ClienteViewModel> Update(ClienteViewModel obj)
        {
            await _clienteService.Update(_mapper.Map<ClienteViewModel, Cliente>(obj));
            return obj;
        }

        public async Task Remove(Guid id)
        {
            await _clienteService.Remove(id);
        }

        public async Task<IEnumerable<ClienteViewModel>> Search(Expression<Func<Cliente, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(await _clienteService.Search(predicate));
        }

        public async Task<ClienteViewModel> GetOne(Expression<Func<Cliente, bool>> predicate)
        {
            return _mapper.Map<Cliente, ClienteViewModel>(await _clienteService.GetOne(predicate));
        }
    }
}