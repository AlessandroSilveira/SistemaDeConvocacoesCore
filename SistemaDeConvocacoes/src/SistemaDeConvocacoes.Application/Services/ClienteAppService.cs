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

        public async Task<ClienteViewModel> AddAsync(ClienteViewModel obj)
        {
            var cliente = _mapper.Map<ClienteViewModel, Cliente>(obj);
            await _clienteService.AddAsync(cliente);

            return obj;
        }

        public async Task<ClienteViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Cliente, ClienteViewModel>(await _clienteService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<ClienteViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(await _clienteService.GetAllAsync());
        }

        public async Task<ClienteViewModel> UpdateAsync(ClienteViewModel obj)
        {
            await _clienteService.UpdateAsync(_mapper.Map<ClienteViewModel, Cliente>(obj));
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
            await _clienteService.RemoveAsync(id);
        }

        public async Task<IEnumerable<ClienteViewModel>> SearchAsync(Expression<Func<Cliente, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(await _clienteService.SearchAsync(predicate));
        }

        public async Task<ClienteViewModel> GetOneAsync(Expression<Func<Cliente, bool>> predicate)
        {
            return _mapper.Map<Cliente, ClienteViewModel>(await _clienteService.GetOneAsync(predicate));
        }
    }
}