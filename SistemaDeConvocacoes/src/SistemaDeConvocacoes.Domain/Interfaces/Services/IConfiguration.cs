namespace SistemaDeConvocacoes.Domain.Interfaces.Services
{
    public interface IConfiguration
    {
        string ObterSmtp();
        string ObterEmailFrom();
        string ObterPortaServidorEmail();
        string ObterPasswordEmail();
    }
}