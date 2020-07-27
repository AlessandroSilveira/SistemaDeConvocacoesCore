using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Cargo
    {
        public Guid CargoId { get; set; }
        public Guid ProcessoId { get; set; }
        public string Nome { get; set; }
        public string CodigoCargo { get; set; }
        public bool Ativo { get; set; }

        public virtual Processo Processo { get; set; }
    }
}
