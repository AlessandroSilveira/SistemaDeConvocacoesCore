using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Documentos
    {
        public Guid DocumentoId { get; set; }
        public Guid ProcessoId { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Path { get; set; }
        public bool Ativo { get; set; }

        public virtual Processos Processo { get; set; }
    }
}
