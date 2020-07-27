using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;
using SistemaDeConvocacoes.Infra.Repositories.Base;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class ConvocacaoRepository : RepositoryBase<Convocacao>, IConvocacaoRepository
    {
        public ConvocacaoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}