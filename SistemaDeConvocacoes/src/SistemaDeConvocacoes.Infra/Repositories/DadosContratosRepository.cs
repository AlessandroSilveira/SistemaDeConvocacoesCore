using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class DadosContratosRepository : Repository<DadosContato>, IDadosContatoRepository
    {
        public DadosContratosRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}