using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class ConvocadosRepository : Repository<Convocados>, IConvocadosRepository
    {
        public ConvocadosRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}