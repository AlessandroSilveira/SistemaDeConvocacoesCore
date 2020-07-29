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
    public class PessoaAppService : IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;
        private readonly IMapper _mapper;

        public PessoaAppService(IPessoaService pessoaService, IMapper mapper)
        {
            _pessoaService = pessoaService;
            _mapper = mapper;
        }

        public void Dispose()
        {
            _pessoaService.Dispose();
        }

        public async Task<PessoaViewModel> AddAsync(PessoaViewModel obj)
        {
            var pessoa = _mapper.Map<PessoaViewModel, Pessoa>(obj);

            await _pessoaService.AddAsync(pessoa);

            return obj;
        }

        public async Task<PessoaViewModel> GetByIdAsync(Guid id)
        {
            return _mapper.Map<Pessoa, PessoaViewModel>(await _pessoaService.GetByIdAsync(id));
        }

        public async Task<IEnumerable<PessoaViewModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(await _pessoaService.GetAllAsync());
        }

        public async Task<PessoaViewModel> UpdateAsync(PessoaViewModel obj)
        {
            await _pessoaService.UpdateAsync(_mapper.Map<PessoaViewModel, Pessoa>(obj));

            return obj;
        }

        public async Task RemoveAsync(Guid id)
        {
            await _pessoaService.RemoveAsync(id);
        }

        public async Task<IEnumerable<PessoaViewModel>> SearchAsync(Expression<Func<Pessoa, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(await _pessoaService.SearchAsync(predicate));
        }

        public async Task<PessoaViewModel> GetOneAsync(Expression<Func<Pessoa, bool>> predicate)
        {
            return _mapper.Map<Pessoa, PessoaViewModel>(await _pessoaService.GetOneAsync(predicate));
        }

        Task<PessoaViewModel> IPessoaAppService.GetOneAsync(Expression<Func<Pessoa, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}