using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class AspNetUserLoginsRepository : Repository<AspNetUserLogins>, IAspNetUserLoginsRepository
    {
        public AspNetUserLoginsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}