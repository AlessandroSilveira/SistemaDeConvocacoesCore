using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class DadosPessoaisRepository : Repository<DadosPessoais>, IDadosPessoaisRepository
    {
        public DadosPessoaisRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}