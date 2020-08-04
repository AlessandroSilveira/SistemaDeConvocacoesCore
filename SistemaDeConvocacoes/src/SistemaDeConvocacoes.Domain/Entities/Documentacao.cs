using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Documentacao
    {
       
        public Guid DocumentoId { get; set; }
        public Guid ConvocacaoId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Path { get; set; }
        public bool Ativo { get; set; }
        public virtual Convocacao Convocacao { get; set; }
    }
}