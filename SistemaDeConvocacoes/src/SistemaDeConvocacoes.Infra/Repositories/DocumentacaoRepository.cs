using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;
using SistemaDeConvocacoes.Infra.Repositories.Base;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class DocumentacaoRepository : RepositoryBase<Documentacao>, IDocumentacaoRepository
    {
        public DocumentacaoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}