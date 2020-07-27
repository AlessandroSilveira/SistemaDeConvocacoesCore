using System;
using SistemaDeConvocacoes.Domain.Interfaces;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Admin
    {
        public Guid AdminId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Empresa { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public byte[] Imagem { get; set; }
        public bool Ativo { get; set; }
        public string Senha { get; set; }
      
    }
}
