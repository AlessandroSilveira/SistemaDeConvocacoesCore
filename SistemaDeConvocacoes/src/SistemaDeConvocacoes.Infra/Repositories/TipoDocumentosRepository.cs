using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Infra.Context;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;

namespace SistemaDeConvocacoes.Infra.Repositories
{
    public class TipoDocumentosRepository : Repository<TipoDocumento>, ITipoDocumentoRepository
    {
        public TipoDocumentosRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}