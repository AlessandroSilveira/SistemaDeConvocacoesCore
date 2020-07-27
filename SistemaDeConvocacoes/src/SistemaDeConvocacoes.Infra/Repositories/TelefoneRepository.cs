using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;
using SistemaDeConvocacoes.Infra.Repositories.Base;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class TelefoneRepository : RepositoryBase<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}