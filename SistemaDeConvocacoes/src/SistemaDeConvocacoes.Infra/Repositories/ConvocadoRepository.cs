using System;
using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;
using SistemaDeConvocacoes.Infra.Repositories.Base;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class ConvocadoRepository : RepositoryBase<Convocado>, IConvocadoRepository
    {
        public ConvocadoRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void SalvarCandidatos(string file)
        {
            throw new NotImplementedException();
        }
    }
}