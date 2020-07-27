namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Telefones
    {
        public int IdTelefone { get; set; }
        public string CodigoPessoa { get; set; }
        public string CodTipoTelefone { get; set; }
        public string Ddd { get; set; }
        public string Telefone { get; set; }
        public string AceitaSms { get; set; }
    }
}
