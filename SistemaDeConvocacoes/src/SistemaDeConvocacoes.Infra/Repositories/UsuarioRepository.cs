﻿using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;
using SistemaDeConvocacoes.Infra.Repositories.Base;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}