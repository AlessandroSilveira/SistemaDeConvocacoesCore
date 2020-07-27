using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class PrimeiroAcesso
    {
        public Guid PrimeiroAcessoId { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public Guid ConvocadoId { get; set; }
    }
}
