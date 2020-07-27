using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class DocumentoCandidatoRepository : Repository<DocumentoCandidato>, IDocumentoCandidatoRepository
    {
        public DocumentoCandidatoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}