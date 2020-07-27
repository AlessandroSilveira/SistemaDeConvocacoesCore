using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Telefone
    {
        public int IdTelefone { get; set; }
        public string CodigoPessoa { get; set; }
        public string CodTipoTelefone { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public string AceitaSms { get; set; }
    }
}
