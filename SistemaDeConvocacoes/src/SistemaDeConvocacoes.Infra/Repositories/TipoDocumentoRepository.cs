using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;
using SistemaDeConvocacoes.Infra.Repositories.Base;

namespace SistemaDeConvocacoes.Infra.Repositories
{
	public class TipoDocumentoRepository : RepositoryBase<TipoDocumento>, ITipoDocumentoRepository
	{
		public TipoDocumentoRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
