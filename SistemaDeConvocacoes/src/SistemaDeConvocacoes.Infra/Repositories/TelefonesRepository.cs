using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class TelefonesRepository : Repository<Telefones>, ITelefonesRepository
    {
        public TelefonesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}