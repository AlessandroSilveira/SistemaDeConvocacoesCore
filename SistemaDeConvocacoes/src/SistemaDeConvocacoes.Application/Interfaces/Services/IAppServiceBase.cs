﻿using System.Collections.Generic;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

    }
}