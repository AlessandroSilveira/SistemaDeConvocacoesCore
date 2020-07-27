using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class TelefoneRepository : Repository<Telefone> , ITelefoneRepository
    {
        public TelefoneRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}