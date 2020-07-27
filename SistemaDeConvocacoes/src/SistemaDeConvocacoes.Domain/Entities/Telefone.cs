using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Telefone
    {
        public Guid TelefoneId { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }
        public Guid? PessoaIdPessoaId { get; set; }

        public virtual Pessoa PessoaIdPessoa { get; set; }
    }
}
