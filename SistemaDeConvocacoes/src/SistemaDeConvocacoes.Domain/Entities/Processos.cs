using System;
using System.Collections.Generic;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Processos
    {
        public Processos()
        {
            Cargos = new HashSet<Cargos>();
            Documentos = new HashSet<Documentos>();
        }

        public Guid ProcessoId { get; set; }
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public string TextoDeAceitacaoDaConvocacao { get; set; }
        public string TextoInicialTelaConvocado { get; set; }
        public string TextoParaDesistentes { get; set; }
        public bool Ativo { get; set; }

        public virtual Clientes Cliente { get; set; }
        public virtual ICollection<Cargos> Cargos { get; set; }
        public virtual ICollection<Documentos> Documentos { get; set; }
    }
}
