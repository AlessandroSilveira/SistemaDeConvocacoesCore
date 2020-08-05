using System;
using System.Collections.Generic;

namespace SistemaDeConvocacoes.Domain.Entities
{
    public partial class Processo
    {
        public Processo()
        {
            Cargos = new HashSet<Cargo>();
            Documentos = new HashSet<Documento>();
        }

        public Guid ProcessoId { get; set; }
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public string TextoDeAceitacaoDaConvocacao { get; set; }
        public string TextoInicialTelaConvocado { get; set; }
        public string TextoParaDesistentes { get; set; }
        public bool Ativo { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Cargo> Cargos { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }


    }
}
