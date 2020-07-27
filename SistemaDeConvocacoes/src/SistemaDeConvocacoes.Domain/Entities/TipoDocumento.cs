using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class TipoDocumento
    {
        public Guid TipoDocumentoId { get; set; }
        public string TipoDocumentos { get; set; }
        public bool Ativo { get; set; }
        public Guid ProcessoId { get; set; }
    }
}
