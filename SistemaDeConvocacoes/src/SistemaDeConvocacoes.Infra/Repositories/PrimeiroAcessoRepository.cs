using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;
using SistemaDeConvocacoes.Infra.Repositories.Base;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class PrimeiroAcessoRepository : RepositoryBase<PrimeiroAcesso>, IPrimeiroAcessoRepository
    {
        public PrimeiroAcessoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}