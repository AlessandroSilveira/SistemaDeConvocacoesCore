﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;

namespace SistemaDeConvocacoes.Domain.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void DisposeAsync()
        {
            _pessoaRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Pessoa Add(Pessoa obj)
        {
            return _pessoaRepository.Add(obj);
        }

        public Pessoa GetByIdAsync(Guid id)
        {
            return _pessoaRepository.GetById(id);
        }

        public IEnumerable<Pessoa> GetAll()
        {
            return _pessoaRepository.GetAll();
        }

        public Pessoa Update(Pessoa obj)
        {
            return _pessoaRepository.Update(obj);
        }

        public void Remove(Guid id)
        {
            _pessoaRepository.Remove(id);
        }

        public IEnumerable<Pessoa> Search(Expression<Func<Pessoa, bool>> predicate)
        {
            return _pessoaRepository.Search(predicate);
        }

        public Pessoa GetOne(Expression<Func<Pessoa, bool>> predicate)
        {
            return _pessoaRepository.GetOne(predicate);
        }
    }
}