using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class AspNetUsersRepository : Repository<AspNetUsers>, IAspNetUsersRepository
    {
        public AspNetUsersRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}