using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class AspNetUserClaimsRepository : Repository<AspNetUserClaims>, IAspNetUserClaimsRepository
    {
        public AspNetUserClaimsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}