using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class ClientesRepository : Repository<Clientes>, IClientesRepository
    {
        public ClientesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}