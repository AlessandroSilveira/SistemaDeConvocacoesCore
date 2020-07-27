using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class DocumentoRepository : Repository<Documentos>, IDocumentoRepository
    {
        public DocumentoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}