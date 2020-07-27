using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class AspNetUserRolesRepository : Repository<AspNetUserRoles>, IAspNetUserRolesRepository
    {
        public AspNetUserRolesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}