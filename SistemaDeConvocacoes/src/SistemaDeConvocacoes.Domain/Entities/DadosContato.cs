﻿namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class DadosContato
    {
        public string CodigoPessoa { get; set; }
        public string EMail { get; set; }
        public string Cep { get; set; }
        public string TipoDeLogradouro { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public int? IdConcurso { get; set; }
    }
}
