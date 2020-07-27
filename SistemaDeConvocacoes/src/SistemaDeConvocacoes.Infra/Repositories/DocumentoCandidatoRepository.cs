using SistemaDeConvocacoes.Domain.Entities;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Infra.Context.ASPNetCoreIdentity.Data;
using SistemaDeConvocacoes.Infra.Repositories.Base;

namespace SistemaDeConvocacoes.Infra.Repositories
{
	public class DocumentoCandidatoRepository : RepositoryBase<DocumentoCandidato>, IDocumentoCandidatoRepository
	{
		public DocumentoCandidatoRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}
