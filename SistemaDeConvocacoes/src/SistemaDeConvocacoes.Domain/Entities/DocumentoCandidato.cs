using System;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class DocumentoCandidato
    {
        public Guid DocumentoCandidatoId { get; set; }
        public Guid ProcessoId { get; set; }
        public Guid ConvocadoId { get; set; }
        public string Documento { get; set; }
        public DateTime DataInclusao { get; set; }
        public string Path { get; set; }
        public string Ativo { get; set; }
        public string TipoDocumento { get; set; }
    }
}
