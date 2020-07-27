using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class ConvocacoesRepository : Repository<Convocacoes>, IConvocacoesRepository
    {
        public ConvocacoesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}