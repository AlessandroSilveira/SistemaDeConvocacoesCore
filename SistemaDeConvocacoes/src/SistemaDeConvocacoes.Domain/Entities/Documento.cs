using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Documento
    {
        public Guid DocumentoId { get; set; }
        public Guid ProcessoId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Path { get; set; }
        public bool Ativo { get; set; }

        public virtual Processo Processo { get; set; }
    }
}
