using SisConv.Application.ViewModels;
using SistemaDeConvocacoes.Application.ViewModels;

namespace SistemaDeConvocacoes.Application.Interfaces.Services
{
    public interface IEmailAppService
    {
        void EnviarEmail(ConvocadoViewModel convocacao);
    }
}