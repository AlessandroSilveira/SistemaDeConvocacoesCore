using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.Services;
using SistemaDeConvocacoes.Domain.Helpers;
using SistemaDeConvocacoes.Domain.Interfaces;
using SistemaDeConvocacoes.Domain.Interfaces.Base;
using SistemaDeConvocacoes.Domain.Interfaces.Helper;
using SistemaDeConvocacoes.Domain.Interfaces.Repositories;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using SistemaDeConvocacoes.Domain.Interfaces.Services.Base;
using SistemaDeConvocacoes.Domain.Services;
using SistemaDeConvocacoes.Infra.Repositories;
using SistemaDeConvocacoes.Infra.Repositories.Base;
using SistemaDeConvocacoes.Presentation.Helpers;

namespace SistemaDeConvocacoes.Presentation.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
       
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services
                .AddScoped<IClienteAppService, ClienteAppService>()
                .AddScoped<IPessoaAppService, PessoaAppService>()
                .AddScoped<ITelefoneAppService, TelefoneAppService>()
                .AddScoped<IUsuarioAppService, UsuarioAppService>()
                .AddScoped<IPrimeiroAcessoAppService, PrimeiroAcessoAppService>()
                .AddScoped<IAdminAppService, AdminAppService>()
                .AddScoped<IProcessoAppService, ProcessoAppService>()
                .AddScoped<ICargoAppService, CargoAppService>()
                .AddScoped<IConvocadoAppService, ConvocadoAppService>()
                .AddScoped<IDadosConvocacaoAppService, DadosConvocacaoAppService>()
                .AddScoped<IConvocacaoAppService, ConvocacaoAppService>()
                .AddScoped<IDocumentacaoAppService, DocumentacaoAppService>()
                .AddScoped<IDocumentoCandidatoAppService, DocumentoCandidatoAppService>()
                .AddScoped<ITipoDocumentoAppService, TipoDocumentoAppService>()


                //Domain
                .AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>))
                .AddScoped<IClienteService, ClienteService>()
                .AddScoped<IPessoaService, PessoaService>()
                .AddScoped<IUsuarioService, UsuarioService>()
                .AddScoped<ITelefoneService, TelefoneService>()
                .AddScoped<IPrimeiroAcessoService, PrimeiroAcessoService>()
                .AddScoped<IAdminService, AdminService>()
                .AddScoped<IProcessoService, ProcessoService>()
                .AddScoped<ICargoService, CargoService>()
                .AddScoped<IConvocadoService, ConvocadoService>()
                .AddScoped<IDadosConvocadosService, DadosConvocadosService>()
                .AddScoped<IConvocacaoService, ConvocacaoService>()
                .AddScoped<IDocumentacaoService, DocumentacaoService>()
                .AddScoped<IDocumentoCandidatoService, DocumentoCandidatoService>()
                .AddScoped<ITipoDocumentoService, TipoDocumentoService>()



                //Infra Dados
                .AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>))
                .AddScoped<IClienteRepository, ClienteRepository>()
                .AddScoped<IPessoaRepository, PessoaRepository>()
                .AddScoped<ITelefoneRepository, TelefoneRepository>()
                .AddScoped<IUsuarioRepository, UsuarioRepository>()
                .AddScoped<IPrimeiroAcessoRepository, PrimeiroAcessoRepository>()
                .AddScoped<IAdminRepository, AdminRepository>()
                .AddScoped<IProcessoRepository, ProcessoRepository>()
                .AddScoped<ICargoRepository, CargoRepository>()
                .AddScoped<IConvocadoRepository, ConvocadoRepository>()
                .AddScoped<IDadosConvocadosRepository, DadosConvocadosRepository>()
                .AddScoped<IConvocacaoRepository, ConvocacaoRepository>()
                .AddScoped<ISysConfig, SysConfig>()
                .AddScoped<IDocumentacaoRepository, DocumentacaoRepository>()
                .AddScoped<IListaOpcoes, ListasOpcoes>()
                .AddScoped<IEnumDescription, EnumDescription>()
                .AddScoped<IMontaListaComEnum, MontaListaComEnum>()
                .AddScoped<IPasswordGeneratorService, PasswordGeneratorService>()
                .AddScoped<IDocumentoCandidatoRepository, DocumentoCandidatoRepository>()
                .AddScoped<ITipoDocumentoRepository, TipoDocumentoRepository>()

                .AddScoped<SeedHelpers>();
        }      
    }
}
