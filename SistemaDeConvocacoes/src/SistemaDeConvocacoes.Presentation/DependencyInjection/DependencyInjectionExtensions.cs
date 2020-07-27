using Microsoft.Extensions.DependencyInjection;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.Services;
using SistemaDeConvocacoes.Domain.Interfaces.Services;
using SistemaDeConvocacoes.Domain.Services;

namespace SistemaDeConvocacoes.Infra.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
       
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services
                .AddScoped<IConvocacoesService, ConvocacoesService>()
                .AddScoped<IConvocadosService, ConvocadosService>()
                .AddScoped<IDocumentosService, DocumentosService>()
                .AddScoped<IPrimeiroAcessoAppService, PrimeiroAcessoAppService>()
                .AddScoped<IProcessosService, ProcessosService>();
        }

       
    }
}
