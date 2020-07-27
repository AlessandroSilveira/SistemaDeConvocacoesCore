using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class AspNetRolesRepository : Repository<AspNetRoles>,IAspNetRolesRepository
    {
        public AspNetRolesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}