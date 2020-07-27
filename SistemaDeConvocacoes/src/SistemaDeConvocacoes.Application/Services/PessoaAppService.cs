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

        public PessoaViewModel Add(PessoaViewModel obj)
        {
            var pessoa = _mapper.Map<PessoaViewModel, Pessoa>(obj);
            _pessoaService.Add(pessoa);
            return obj;
        }

        public PessoaViewModel GetById(Guid id)
        {
            return _mapper.Map<Pessoa, PessoaViewModel>(_pessoaService.GetById(id));
        }

        public IEnumerable<PessoaViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(_pessoaService.GetAll());
        }

        public PessoaViewModel Update(PessoaViewModel obj)
        {

            _pessoaService.Update(_mapper.Map<PessoaViewModel, Pessoa>(obj));

            return obj;
        }

        public void Remove(Guid id)
        {
            _pessoaService.Remove(id);
        }

        public IEnumerable<PessoaViewModel> Search(Expression<Func<Pessoa, bool>> predicate)
        {
            return _mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(_pessoaService.Search(predicate));
        }

        public PessoaViewModel GetOne(Expression<Func<Pessoa, bool>> predicate)
        {
            return _mapper.Map<Pessoa, PessoaViewModel>(_pessoaService.GetOne(predicate));
        }
    }
}