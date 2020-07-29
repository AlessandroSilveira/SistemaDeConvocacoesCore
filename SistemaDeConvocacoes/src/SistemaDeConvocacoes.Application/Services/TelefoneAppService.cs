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
    public class TelefoneAppService : ITelefoneAppService
    {
        private readonly ITelefoneService _telefoneService;
        private readonly IMapper _mapper;

        public TelefoneAppService(ITelefoneService telefoneService, IMapper mapper)
        {
            _telefoneService = telefoneService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _telefoneService.Dispose();
        }

        public async Task<TelefoneViewModel> AddAsync(TelefoneViewModel obj)
        {
            var telefone = _mapper.Map<TelefoneViewModel, Telefone>(obj);            
            await _telefoneService.AddAsync(telefone);            
            return obj;
        }

        public async Task<TelefoneViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Telefone, TelefoneViewModel>(await _telefoneService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<TelefoneViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Telefone>, IEnumerable<TelefoneViewModel>>(await _telefoneService.GetAllAsync());
        }

        public async Task<TelefoneViewModel> UpdateAsync(TelefoneViewModel obj)
        {           
            await _telefoneService.UpdateAsync(_mapper.Map<TelefoneViewModel, Telefone>(obj));           
            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {           
            await _telefoneService.RemoveAsync(id);            
        }

        public async Task<IEnumerable<TelefoneViewModel>> SearchAsync(Expression<Func<Telefone, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Telefone>, IEnumerable<TelefoneViewModel>>(
                await _telefoneService.SearchAsync(predicate));
        }

        public async Task<TelefoneViewModel> GetOneAsync(Expression<Func<Telefone, bool>> predicate)
        {
            return _mapper.Map<Telefone, TelefoneViewModel>(await _telefoneService.GetOneAsync(predicate));
        }
    }
}