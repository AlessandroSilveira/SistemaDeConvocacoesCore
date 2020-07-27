using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class DadosPessoais
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public string NaturalidadeUf { get; set; }
        public string Municipio { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Rg { get; set; }
        public DateTime DataExpedicaoRg { get; set; }
        public string OrgaoExpeditorRg { get; set; }
        public string UfRg { get; set; }
        public string NecessidadesEspeciais { get; set; }
        public string DataENascimento2 { get; set; }
        public int? IdConcurso { get; set; }
        public string DataExpedicaoRg2 { get; set; }
    }
}
