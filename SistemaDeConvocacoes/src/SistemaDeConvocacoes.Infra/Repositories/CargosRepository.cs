using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class CargosRepository : Repository<Cargos>, ICargosRepository
    {
        public CargosRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}