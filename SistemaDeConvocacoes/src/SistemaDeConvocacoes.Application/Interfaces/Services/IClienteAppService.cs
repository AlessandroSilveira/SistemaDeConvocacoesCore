﻿using SistemaDeConvocacoes.Application.ViewModels;
using SistemaDeConvocacoes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IClienteAppService : IDisposable
    {
        ClienteViewModel Add(ClienteViewModel obj);

        ClienteViewModel GetById(Guid id);

        IEnumerable<ClienteViewModel> GetAll();

        ClienteViewModel Update(ClienteViewModel obj);

        void Remove(Guid id);

        IEnumerable<ClienteViewModel> Search(Expression<Func<Cliente, bool>> predicate);

        ClienteViewModel GetOne(Expression<Func<Cliente, bool>> predicate);
    }
}